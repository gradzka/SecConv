using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.DirectX.DirectSound;
using System.IO;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.Windows.Forms;

namespace SecConvClient
{
    class Voice
    {
        private CaptureBufferDescription captureBufferDescription;
        private AutoResetEvent autoResetEvent;
        private Notify notify;
        private WaveFormat waveFormat;
        private Capture capture;
        private int bufferSize;
        private CaptureBuffer captureBuffer;
        private UdpClient udpClient;                //Listens and sends data on port 1550, used in synchronous mode.
        private Device device;
        private SecondaryBuffer playbackBuffer;
        private BufferDescription playbackBufferDescription;
        private Socket clientSocket;
        private volatile bool bStop;                         //Flag to end the Start and Receive threads.
        private IPEndPoint otherPartyIP;            //IP of party we want to make a call.
        private EndPoint otherPartyEP;
        private volatile bool bIsCallActive;                 //Tells whether we have an active call.
        private Vocoder vocoder;
        private byte[] byteData = new byte[1024];   //Buffer to store the data received.
        private volatile int nUdpClientFlag;                 //Flag used to close the udpClient socket.

        public Voice()
        {
            Initialize();
        }

        /*
         * Initializes all the data members.
         */
        private void Initialize()
        {
            try
            {
                device = new Device();
                device.SetCooperativeLevel(Program.secConv, CooperativeLevel.Normal);

                CaptureDevicesCollection captureDeviceCollection = new CaptureDevicesCollection();

                DeviceInformation deviceInfo = captureDeviceCollection[0];

                capture = new Capture(deviceInfo.DriverGuid);

                short channels = 1; //Stereo.
                short bitsPerSample = 16; //16Bit, alternatively use 8Bits.
                int samplesPerSecond = 22050; //11KHz use 11025 , 22KHz use 22050, 44KHz use 44100 etc.

                //Set up the wave format to be captured.
                waveFormat = new WaveFormat();
                waveFormat.Channels = channels;
                waveFormat.FormatTag = WaveFormatTag.Pcm;
                waveFormat.SamplesPerSecond = samplesPerSecond;
                waveFormat.BitsPerSample = bitsPerSample;
                waveFormat.BlockAlign = (short)(channels * (bitsPerSample / (short)8));
                waveFormat.AverageBytesPerSecond = waveFormat.BlockAlign * samplesPerSecond;

                captureBufferDescription = new CaptureBufferDescription();
                captureBufferDescription.BufferBytes = waveFormat.AverageBytesPerSecond / 5;//approx 200 milliseconds of PCM data.
                captureBufferDescription.Format = waveFormat;

                playbackBufferDescription = new BufferDescription();
                playbackBufferDescription.BufferBytes = waveFormat.AverageBytesPerSecond / 5;
                playbackBufferDescription.Format = waveFormat;
                playbackBuffer = new SecondaryBuffer(playbackBufferDescription, device);

                bufferSize = captureBufferDescription.BufferBytes;

                bIsCallActive = false;
                nUdpClientFlag = 0;

                //Using UDP sockets
                clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                clientSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                EndPoint ourEP = new IPEndPoint(IPAddress.Any, 14450);
                //Listen asynchronously on port 1450 for coming messages.
                clientSocket.Bind(ourEP);

                //Receive data from any IP.
                EndPoint remoteEP = (EndPoint)(new IPEndPoint(IPAddress.Any, 0));

                byteData = new byte[1024];
                //Receive data asynchornously.
                clientSocket.BeginReceiveFrom(byteData,
                                           0, byteData.Length,
                                           SocketFlags.None,
                                           ref remoteEP,
                                           new AsyncCallback(OnReceive),
                                           null);
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił problem z inicjalizacją obiektu Voice!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Call()
        {
            try
            {
                //Get the IP we want to call.
                //otherPartyIP = new IPEndPoint(IPAddress.Parse(txtCallToIP.Text), 1450);
                string ipAddress = Program.secConv.listView1.SelectedItems[0].SubItems[1].Text.ToString();
                otherPartyIP = new IPEndPoint(IPAddress.Parse(ipAddress), 14450);
                otherPartyEP = (EndPoint)otherPartyIP;

                //Get the vocoder to be used.
               /* if (cmbCodecs.SelectedText == "A-Law")
                {
                    vocoder = Vocoder.ALaw;
                }
                else if (cmbCodecs.SelectedText == "u-Law")
                {
                    vocoder = Vocoder.uLaw;
                }
                else if (cmbCodecs.SelectedText == "None")*/
                {
                    vocoder = Vocoder.None;
                }

                //Send an invite message.
                char comm = (char)10;
                string message = comm + " " + Program.userLogin +" "+ vocoder +" <EOF>";
                SendMessage(message, otherPartyEP);
                //if (callOut.ShowDialog(Program.secConv) == DialogResult.No)
                //{ 
                //    message = (char)6 + " <EOF>"; //FAIL
                //    SendMessage(message, otherPartyEP);
                //}
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił problem z nawiązaniem połączenia!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CancelCall()
        {
            try
            {
                string message = (char)6 + " <EOF>"; //FAIL
                SendMessage(message, otherPartyEP);
                Program.secConv.gBCallOut.Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił problem z anulowaniem połączenia!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void OnSend(IAsyncResult ar)
        {
            try
            {
                clientSocket.EndSendTo(ar);
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił problem podczas wysyłania pakietów!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
         * Commands are received asynchronously. OnReceive is the handler for them.
         */
        private void OnReceive(IAsyncResult ar)
        {
            try
            {
                EndPoint receivedFromEP = new IPEndPoint(IPAddress.Any, 0);

                //Get the IP from where we got a message.
                clientSocket.EndReceiveFrom(ar, ref receivedFromEP);

                //Convert the bytes received into an object of type Data.
                string message = Encoding.ASCII.GetString(byteData);

                //Data msgReceived = new Data(byteData);
                //Act according to the received message.
                switch (message[0])
                {
                    //We have an incoming call.
                    case (char)10:
                        {
                            string msgTmp = string.Empty;
                            if (bIsCallActive == false)
                            {
                                //split message
                                //message = comm + " " + Program.userLogin + " " + vocoder + " <EOF>";
                                string []msgTable = message.Split(' ');
                                //We have no active call.

                                //Ask the user to accept the call or not.
                                //if (MessageBox.Show("Call coming from " + msgReceived.strName + ".\r\n\r\nAccept it?",
                                //   "VoiceChat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                                Program.secConv.Invoke((MethodInvoker)delegate { Program.secConv.gBCallIn.Visible = true; });
                                Program.secConv.Invoke((MethodInvoker)delegate { Program.secConv.LUserCallIn.Text = msgTable[1]; });
                                Program.secConv.callerEndPoint = receivedFromEP;
                                //Program.secConv.Refresh();
                            }
                            else
                            {
                                DeclineCall(receivedFromEP);
                            }
                            break;
                        }

                    //OK is received in response to an Invite.
                    case (char)5:
                        {
                            //callOut.Close();
                            //Start a call.
                            InitializeCall();
                            break;
                        }

                    //Remote party is busy.
                    case (char)6: //FAIL
                        {
                            //send msg to DB with history
                            Program.client = new SynchronousClient(Program.serverAddress);
                            Communique.CallState(Program.userLogin, Program.secConv.listView1.SelectedItems[0].Text, DateTime.Now, TimeSpan.Zero);
                            //refresh user panel with histories
                            string[] historyDetails = new string[3];
                            historyDetails[0] = Program.secConv.listView1.SelectedItems[0].Text;
                            historyDetails[1] = DateTime.Now.ToString();
                            historyDetails[2] = "nieodebrane";
                            Program.secConv.listView2.Items.Insert(0, (new ListViewItem(historyDetails)));
                            Program.secConv.listView2.Refresh();
                            MessageBox.Show("Znajomy nie jest dostępny! Wysłano powiadomienie o próbie nawiązania połączenia.", "Niedostępny znajomy!");
                            //disconect with server
                            Program.client.Disconnect();
                            //close ring panel
                            Program.secConv.Invoke((MethodInvoker)delegate { Program.secConv.gBCallIn.Visible = false; });
                            if (Program.secConv.gBCallOut.Visible==true)
                            {
                                CancelCall();
                                MessageBox.Show("Połączenie odrzucone.", "SecConv", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            break;
                        }

                    case (char)12: //BYE
                        {
                            //Check if the Bye command has indeed come from the user/IP with which we have
                            //a call established. This is used to prevent other users from sending a Bye, which
                            //would otherwise end the call.
                            if (receivedFromEP.Equals(otherPartyEP) == true)
                            {
                                //tu zatrzymaj timer
                                Program.secConv.timerConv.Stop();

                                //if (conv != null && !conv.IsDisposed)
                                //{
                                //    conv.Close();
                                //}
                                //End the call.
                                UninitializeCall();
                            }
                            break;
                        }
                }

                byteData = new byte[1024];
                //Get ready to receive more commands.
                clientSocket.BeginReceiveFrom(byteData, 0, byteData.Length, SocketFlags.None, ref receivedFromEP, new AsyncCallback(OnReceive), null);
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił problem podczas odbierania pakietów!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AcceptCall(EndPoint receivedFromEP)
        {
            string msgTmp = (char)5 + " <EOF>";
            SendMessage(msgTmp, receivedFromEP);
            vocoder = Vocoder.None;//msgReceived.vocoder;
            otherPartyEP = receivedFromEP;
            otherPartyIP = (IPEndPoint)receivedFromEP;
            InitializeCall();
        }

        public void DeclineCall(EndPoint receivedFromEP)
        {
            string msgTmp = (char)6 + " <EOF>"; //FAIL
            SendMessage(msgTmp, receivedFromEP); //to another user
            //caller date state
            string[] historyDetails = new string[3];
            historyDetails[0] = Program.secConv.LUserCallIn.Text;//get user who initialize call //listView1.SelectedItems[0].Text;
            historyDetails[1] = DateTime.Now.ToString();
            historyDetails[2] = "nieodebrane";
            Program.secConv.listView2.Items.Insert(0, (new ListViewItem(historyDetails)));
            Program.secConv.listView2.Refresh();
            MessageBox.Show("Znajomy nie jest dostępny! Wysłano powiadomienie o próbie nawiązania połączenia.", "Niedostępny znajomy!");
        }

        /*
         * Send synchronously sends data captured from microphone across the network on port 1550.
         */
        private void Send()
        {
            try
            {
                //The following lines get audio from microphone and then send them 
                //across network.

                captureBuffer = new CaptureBuffer(captureBufferDescription, capture);

                CreateNotifyPositions();

                int halfBuffer = bufferSize / 2;

                captureBuffer.Start(true);

                bool readFirstBufferPart = true;
                int offset = 0;

                MemoryStream memStream = new MemoryStream(halfBuffer);
                bStop = false;
                while (!bStop)
                {
                    autoResetEvent.WaitOne();
                    memStream.Seek(0, SeekOrigin.Begin);
                    captureBuffer.Read(offset, memStream, halfBuffer, LockFlag.None);
                    readFirstBufferPart = !readFirstBufferPart;
                    offset = readFirstBufferPart ? 0 : halfBuffer;

                    //TODO: Fix this ugly way of initializing differently.

                    //Choose the vocoder. And then send the data to other party at port 1550.

                   /* if (vocoder == Vocoder.ALaw)
                    {
                        byte[] dataToWrite = ALawEncoder.ALawEncode(memStream.GetBuffer());
                        udpClient.Send(dataToWrite, dataToWrite.Length, otherPartyIP.Address.ToString(), 1550);
                    }
                    else if (vocoder == Vocoder.uLaw)
                    {
                        byte[] dataToWrite = MuLawEncoder.MuLawEncode(memStream.GetBuffer());
                        udpClient.Send(dataToWrite, dataToWrite.Length, otherPartyIP.Address.ToString(), 1550);
                    }
                    else*/
                    {
                        byte[] dataToWrite = memStream.GetBuffer();
                        udpClient.Send(dataToWrite, dataToWrite.Length, otherPartyIP.Address.ToString(), 1550);
                    }
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Wystąpił problem podczas wysyłania pakietów!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                captureBuffer.Stop();

                //Increment flag by one.
                nUdpClientFlag += 1;

                //When flag is two then it means we have got out of loops in Send and Receive.
                while (nUdpClientFlag != 2)
                { }

                //Clear the flag.
                nUdpClientFlag = 0;

                //Close the socket.
                udpClient.Close();
                captureBuffer.Dispose();
            }
        }

        /*
         * Receive audio data coming on port 1550 and feed it to the speakers to be played.
         */
        private void Receive()
        {
            try
            {
                bStop = false;
                IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);

                while (!bStop)
                {
                    //Receive data.
                    byte[] byteData = udpClient.Receive(ref remoteEP);

                    //G711 compresses the data by 50%, so we allocate a buffer of double
                    //the size to store the decompressed data.
                    byte[] byteDecodedData = new byte[byteData.Length * 2];

                    //Decompress data using the proper vocoder.
                    /*if (vocoder == Vocoder.ALaw)
                    {
                        ALawDecoder.ALawDecode(byteData, out byteDecodedData);
                    }
                    else if (vocoder == Vocoder.uLaw)
                    {
                        MuLawDecoder.MuLawDecode(byteData, out byteDecodedData);
                    }
                    else*/
                    {
                        byteDecodedData = new byte[byteData.Length];
                        byteDecodedData = byteData;
                    }


                    //Play the data received to the user.
                    playbackBuffer = new SecondaryBuffer(playbackBufferDescription, device);
                    playbackBuffer.Write(0, byteDecodedData, LockFlag.None);
                    playbackBuffer.Play(0, BufferPlayFlags.Default);
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Wystąpił problem podczas odbierania pakietów!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                nUdpClientFlag += 1;
            }
        }

        private void CreateNotifyPositions()
        {
            try
            {
                autoResetEvent = new AutoResetEvent(false);
                notify = new Notify(captureBuffer);
                BufferPositionNotify bufferPositionNotify1 = new BufferPositionNotify();
                bufferPositionNotify1.Offset = bufferSize / 2 - 1;
                bufferPositionNotify1.EventNotifyHandle = autoResetEvent.SafeWaitHandle.DangerousGetHandle();
                BufferPositionNotify bufferPositionNotify2 = new BufferPositionNotify();
                bufferPositionNotify2.Offset = bufferSize - 1;
                bufferPositionNotify2.EventNotifyHandle = autoResetEvent.SafeWaitHandle.DangerousGetHandle();

                notify.SetNotificationPositions(new BufferPositionNotify[] { bufferPositionNotify1, bufferPositionNotify2 });
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił problem podczas metody \"CreateNotifyPositions()\"!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void UninitializeCall()
        {
            Program.secConv.Invoke((MethodInvoker)delegate { Program.secConv.gbConv.Visible = false; });
            //Set the flag to end the Send and Receive threads.
            bStop = true;

            bIsCallActive = false;
            /* btnCall.Enabled = true;
             btnEndCall.Enabled = false;*/

            //uzupełnić history
            string[] historyDetails = new string[3];
            historyDetails[0] = Program.secConv.LUserConv.Text.Remove(0,2);
            historyDetails[1] = Program.secConv.begin.ToString();
            historyDetails[2] = (Program.secConv.end - Program.secConv.begin).ToString().Split('.')[0];
            Program.secConv.listView2.Items.Insert(0, (new ListViewItem(historyDetails)));
            Program.secConv.listView2.Refresh();
        }

        public void DropCall()
        {
            try
            {
                char comm = (char)12;
                string message = comm + " <EOF>";
                //Send a Bye message to the user to end the call.
                SendMessage(message, otherPartyEP);
                UninitializeCall();
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił problem podczas rozłączania!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeCall()
        {
            Program.secConv.Invoke((MethodInvoker)delegate { Program.secConv.gBCallOut.Visible = false; });
            Program.secConv.Invoke((MethodInvoker)delegate { Program.secConv.gBCallIn.Visible = false; });
            try
            {
                //Start listening on port 1500.
                udpClient = new UdpClient(1550);

                Thread senderThread = new Thread(new ThreadStart(Send));
                Thread receiverThread = new Thread(new ThreadStart(Receive));
                bIsCallActive = true;

                //Start the receiver and sender thread.
                receiverThread.Start();
                senderThread.Start();
                /* btnCall.Enabled = false;
                 btnEndCall.Enabled = true;*/

                //conv = new Conv(login);

                Program.secConv.Invoke((MethodInvoker)delegate { Program.secConv.gbConv.Visible = true; Program.secConv.timerConv.Start(); });
                Program.secConv.begin = DateTime.Now;

                //Program.secConv.timerConv.Start();
                if (Program.secConv.isReceiver == true)
                {
                    Program.secConv.Invoke((MethodInvoker)delegate { Program.secConv.LUserConv.Text = "z " + Program.secConv.LUserCallIn.Text; });
                }
                else
                {
                    Program.secConv.Invoke((MethodInvoker)delegate { Program.secConv.LUserConv.Text = Program.secConv.LUserCallOut.Text; });
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił problem podczas inicjalizacji połączenia!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
         * Send a message to the remote party.
         */
        private void SendMessage(string message, EndPoint sendToEP)
        {
            try
            {
                //Create the message to send.
                //Data msgToSend = new Data();
                //char comm = (char)10;
                //message = comm + " " + Program.userLogin +" "+ vocoder +" <EOF>";

                // msgToSend.strName = txtName.Text;   //Name of the user.
                //msgToSend.strName = "Tajny agent";
                //msgToSend.cmdCommand = cmd;         //Message to send.
                //msgToSend.vocoder = Vocoder.None;        //Vocoder to be used.

                byte[] msg = Encoding.ASCII.GetBytes(message);

                //Send the message asynchronously.
                clientSocket.BeginSendTo(msg, 0, message.Length, SocketFlags.None, sendToEP, new AsyncCallback(OnSend), null);
            }
            catch (Exception)
            {
                MessageBox.Show("Wystąpił problem podczas wysyłania pakietów!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    //Vocoder
    enum Vocoder
    {
        None,   //Don't use any vocoder.
        ALaw,   //A-Law vocoder.
        uLaw,   //u-Law vocoder.
    }

    //The data structure by which the server and the client interact with 
    //each other.
    /*class Data
    {
        //Default constructor.
        public Data()
        {
            this.cmdCommand = Command.Null;
            this.strName = null;
            vocoder = Vocoder.None;
        }

        //Converts the bytes into an object of type Data.
        public Data(byte[] data)
        {
            //The first four bytes are for the Command.
            this.cmdCommand = (Command)BitConverter.ToInt32(data, 0);

            //The next four store the length of the name.
            int nameLen = BitConverter.ToInt32(data, 4);

            //This check makes sure that strName has been passed in the array of bytes.
            if (nameLen > 0)
                this.strName = Encoding.UTF8.GetString(data, 8, nameLen);
            else
                this.strName = null;
        }

        //Converts the Data structure into an array of bytes.
        public byte[] ToByte()
        {
            List<byte> result = new List<byte>();

            //First four are for the Command.
            result.AddRange(BitConverter.GetBytes((int)cmdCommand));

            //Add the length of the name.
            if (strName != null)
                result.AddRange(BitConverter.GetBytes(strName.Length));
            else
                result.AddRange(BitConverter.GetBytes(0));

            //Add the name.
            if (strName != null)
                result.AddRange(Encoding.UTF8.GetBytes(strName));

            return result.ToArray();
        }

        public string strName;      //Name by which the client logs into the room.
        public Command cmdCommand;  //Command type (login, logout, send message, etc).
        public Vocoder vocoder;
    }*/
}

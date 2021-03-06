﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Timers;

//https://msdn.microsoft.com/pl-pl/library/fx6588te(v=vs.110).aspx
namespace SecConvServer
{
    class AsynchronousSocketListener
    {
        private static System.Timers.Timer aTimer;
        private static void SetTimer()
        {
            // Create a timer with a 61 seconds interval.
            aTimer = new System.Timers.Timer(61000);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            DateTime time = DateTime.Now;
            List<long> usersIDToRemove = new List<long>();
            foreach (var item in Program.onlineUsers)
            {
                if((time - item.Value.iAM).TotalSeconds>60)
                {
                    //Program.onlineUsers.Remove(item.Key);
                    usersIDToRemove.Add(item.Key);
                }
            }
            foreach (var item in usersIDToRemove)
            {
                Program.onlineUsers.Remove(item);
            }
        }
        // Thread signal.
        public static ManualResetEvent allDone = new ManualResetEvent(false);

        public static void StartListening()
        {
            // Data buffer for incoming data.
            byte[] bytes = new Byte[1024];

            // Establish the local endpoint for the socket.
            // The DNS name of the computer
            // running the listener is "host.contoso.com".
            IPHostEntry ipHostInfo = Dns.Resolve(Dns.GetHostName());
            int i = 0;
            Console.WriteLine("Choose server IPv4 address:");
            foreach (var item in ipHostInfo.AddressList)
            {
                Console.WriteLine( i + " - " + item);
                i++;
            }
            do
            {
                Console.Write("Type: ");
                i = (int)(Console.ReadKey().KeyChar) - 48;
                Console.WriteLine();
            } while (i < 0 || i >= ipHostInfo.AddressList.Count());

            IPAddress ipAddress = ipHostInfo.AddressList[i];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 11000);

            // Create a TCP/IP socket.
            Socket listener = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.Tcp);

            // Bind the socket to the local endpoint and listen for incoming connections.
            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(100);

                Console.WriteLine("Server is running ("+ipAddress+")");
                SetTimer();
                while (true)
                {
                    // Set the event to nonsignaled state.
                    allDone.Reset();

                    // Start an asynchronous socket to listen for connections.                
                    listener.BeginAccept(
                        new AsyncCallback(AcceptCallback),
                        listener);

                    // Wait until a connection is made before continuing.
                    allDone.WaitOne();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("\nPress ENTER to continue...");
            Console.Read();

        }

        public static void AcceptCallback(IAsyncResult ar)
        {
            // Signal the main thread to continue.
            allDone.Set();

            // Get the socket that handles the client request.
            Socket listener = (Socket)ar.AsyncState;
            Socket handler = listener.EndAccept(ar);

            // Create the state object.
            StateObject state = new StateObject();
            state.workSocket = handler;
            handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                new AsyncCallback(ReadCallback), state);
        }

        public static void ReadCallback(IAsyncResult ar)
        {
            String content = String.Empty;

            // Retrieve the state object and the handler socket
            // from the asynchronous state object.
            StateObject state = (StateObject)ar.AsyncState;
            Socket handler = state.workSocket;
            byte[] sessionKey = null;
            int bytesRead = 0;
            
            //SESSIONKEY_RETURN:
            // Read data from the client socket. 
             bytesRead = handler.EndReceive(ar);

            if (bytesRead > 0)
            {
                // There  might be more data, so store the data received so far.
                state.sb.Append(Encoding.ASCII.GetString(
                    state.buffer, 0, bytesRead));

                // Check for end-of-file tag. If it is not there, read 
                // more data.
                content = state.sb.ToString();
                if (content.IndexOf("<EOF>") > -1)
                {
                    // All the data has been read from the 
                    // client. Display it on the console.
                    Console.WriteLine("Read {0} bytes from socket. \nData : {1}",
                        content.Length, content);

                    string messageBits = Utilities.getBinaryMessage(content);
                    //take 8 bits to recognize the communique
                    int bits8 = Convert.ToInt32(messageBits.Substring(0, 8), 2);//decimal value

                    if (bits8 == 17)
                    {
                        sessionKey = Program.security.SetSessionKey(Convert.FromBase64String(content.Substring(2, content.Length - 8)));
                        state.sessionKey = sessionKey;
                        Send(handler, (char)17 + " " + Convert.ToBase64String(Program.security.GetOwnerPublicKey().ToByteArray()) + " <EOF>");
                        //goto SESSIONKEY_RETURN;  
                        state.buffer = new byte[1024];
                        state.sb = new StringBuilder();
                        handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                        new AsyncCallback(ReadCallback), state);
                    }
                    else
                    {


                        content = Communique.ChooseCommunique(content, state.sessionKey, handler);
                        // Echo the data back to the client.

                        if (bits8 != 2 && bits8 != 11)
                        {
                            Send(handler, content);
                        }

                        if (bits8 == 1 && content == ((char)5).ToString() + " <EOF>") //logIn
                        {

                            string userAddressIP = ((IPEndPoint)handler.RemoteEndPoint).Address.ToString();
                            long userID = Communique.getUserIDHavingAdressIP(userAddressIP);
                            if (userID == -1)
                            {
                                Send(handler, Communique.Fail());
                            }
                            {
                                Send(handler, Communique.LogIP(userID)); //data about friend
                                Thread.Sleep(250);//miliseconds
                                Send(handler, Communique.History(userID));//userID history
                            }
                        }

                        handler.Shutdown(SocketShutdown.Both);
                        handler.Close();

                        if (bits8 == 0)
                        {

                        }
                    }

                }
                else
                {
                    // Not all data received. Get more.
                    handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                    new AsyncCallback(ReadCallback), state);
                }
            }
        }

        private static void Send(Socket handler, String data)
        {
            // Convert the string data to byte data using ASCII encoding.
            byte[] byteData = Encoding.ASCII.GetBytes(data);

            // Begin sending the data to the remote device.
            handler.BeginSend(byteData, 0, byteData.Length, 0,
                new AsyncCallback(SendCallback), handler);
        }

        private static void SendCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.
                Socket handler = (Socket)ar.AsyncState;

                // Complete sending the data to the remote device.
                int bytesSent = handler.EndSend(ar);
                Console.WriteLine("Sent {0} bytes to client.", bytesSent);

                
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.ToString());
            }
        }
    }
}

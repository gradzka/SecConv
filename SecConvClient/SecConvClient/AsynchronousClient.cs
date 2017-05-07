using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SecConvClient
{
    // State object for receiving data from remote device.
    public class StateObject
    {
        // Client socket.
        public Socket workSocket = null;
        // Size of receive buffer.
        public const int BufferSize = 256;
        // Receive buffer.
        public byte[] buffer = new byte[BufferSize];
        // Received data string.
        public StringBuilder sb = new StringBuilder();
    }

    public class AsynchronousClient
    {
        // The port number for the remote device.
        private const int port = 11000;

        // ManualResetEvent instances signal completion.
        public ManualResetEvent connectDone =
            new ManualResetEvent(false);
        public ManualResetEvent sendDone =
            new ManualResetEvent(false);
        public ManualResetEvent receiveDone =
            new ManualResetEvent(false);
        public ManualResetEvent disconnectDone =
            new ManualResetEvent(false);

        // The response from the remote device.
        public String response = String.Empty;

        private String ServerIP = String.Empty;
        private Socket socket;

        public AsynchronousClient(string AddressIP)
        {
            ServerIP = AddressIP;
            // Create a TCP/IP socket.
            socket = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.Tcp);
            // Connect to the remote endpoint.
            socket.BeginConnect(ServerIP, port,
                new AsyncCallback(ConnectCallback), socket);
            connectDone.WaitOne();
            //connectDone.Reset();
        }

        private void ConnectCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.
                Socket client = (Socket)ar.AsyncState;

                // Complete the connection.
                client.EndConnect(ar);

                Console.WriteLine("Socket connected to {0}",
                    client.RemoteEndPoint.ToString());

                // Signal that the connection has been made.
                connectDone.Set();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void Receive()
        {
            try
            {
                // Create the state object.
                StateObject state = new StateObject();
                state.workSocket = socket;
                response = "";

                // Begin receiving the data from the remote device.
                socket.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                    new AsyncCallback(ReceiveCallback), state);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        private void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the state object and the client socket 
                // from the asynchronous state object.
                StateObject state = (StateObject)ar.AsyncState;
                Socket client = state.workSocket;

                // Read data from the remote device.
                int bytesRead = client.EndReceive(ar);

                if (bytesRead > 0)
                {
                    // There might be more data, so store the data received so far.
                    state.sb.Append(Encoding.ASCII.GetString(state.buffer, 0, bytesRead));

                    if (state.sb.ToString().Contains("<EOF>"))
                    {
                        // All the data has arrived; put it in response.
                        response = state.sb.ToString();
                        // Signal that all bytes have been received.
                        receiveDone.Set();
                    }
                    else
                    {
                        // Get the rest of the data.
                        client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                            new AsyncCallback(ReceiveCallback), state);
                    }
                }
                else
                {
                    // All the data has arrived; put it in response.
                    if (state.sb.Length > 0)
                    {
                        response = state.sb.ToString();
                    }
                    // Signal that all bytes have been received.
                    receiveDone.Set();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void Send(String data)
        {
            // Convert the string data to byte data using ASCII encoding.
            byte[] byteData = Encoding.ASCII.GetBytes(data);

            // Begin sending the data to the remote device.
            socket.BeginSend(byteData, 0, byteData.Length, 0,
                new AsyncCallback(SendCallback), socket);
        }
        private void SendCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.
                Socket client = (Socket)ar.AsyncState;

                // Complete sending the data to the remote device.
                int bytesSent = client.EndSend(ar);
                Console.WriteLine("Sent {0} bytes to server.", bytesSent);

                // Signal that all bytes have been sent.
                sendDone.Set();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void Disconnect()
        {
            try
            {
                // Create the state object.
                StateObject state = new StateObject();
                state.workSocket = socket;

                // Begin receiving the data from the remote device.
                socket.BeginDisconnect(true, new AsyncCallback(DisconnectCallback), state);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        private void DisconnectCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.
                Socket client = (Socket)ar.AsyncState;

                // Complete the disconnection.
                client.Shutdown(SocketShutdown.Both);
                client.Close();

                Console.WriteLine("Socket disconnected with {0}",
                    client.RemoteEndPoint.ToString());

                // Signal that the connection has been made.
                disconnectDone.Set();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}

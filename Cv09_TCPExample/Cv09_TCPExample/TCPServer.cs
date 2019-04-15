using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Cv09_TCPExample
{
    class TCPServer
    {
        public const string DefaultIpAddress = "127.0.0.1";
        public const int DefaultPort = 1200;
        public const int ListenerCOunt = 2;

        private IMessageProcessor processor;

        public TCPServer(IMessageProcessor processor, string ipAddress, int port)
        {
            this.processor = processor;

            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(ipAddress), port);
            processor?.Process($"TCP server listening on {endPoint.ToString()}");
            socket.Bind(endPoint);

            socket.Listen(ListenerCOunt);
            Socket acceptedSocket = socket.Accept();
            byte[] acceptedData = new byte[acceptedSocket.SendBufferSize];
            int bufferCount = acceptedSocket.Receive(acceptedData);
            byte[] data = new byte[bufferCount];
            for (int i = 0; i < bufferCount; i++)
            {
                data[i] = acceptedData[i];
            }

            string message = Encoding.Default.GetString(data);
            processor?.Process(message);
        }

        //public void Listen()
        //{
        //    Socket acceptedScoket = Socket.Accept();
        //}
    }
}

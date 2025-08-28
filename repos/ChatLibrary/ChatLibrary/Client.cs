using System;
using System.Net.Sockets;

namespace ChatLibrary
{
    public class Client
    {
        public TcpClient tcpClient { get; private set; }
        public string Name { get; set; }
        public Color color { get; set; }

        public Client (TcpClient tcpClient, string name)
        {
            this.tcpClient = tcpClient;
            Name = name;
        }   
    }
}

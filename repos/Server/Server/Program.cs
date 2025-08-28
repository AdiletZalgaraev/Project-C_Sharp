using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Threading;
using System.Linq.Expressions;
using static ChatLibrary.TcpMessage;
using ChatLibrary;

namespace Server
{
    internal class Program
    {
        static List<TcpClient> clients;
        static TcpListener listener;

        static void ListenClient(object o)
        {
            Client client = new Client((TcpClient)o, "No Name");
            while (client.tcpClient.Connected)
            {
                try
                {
                string message = GetMessage(client.tcpClient);
                if (message != "" && message != null)
                {
                        if(message.IndexOf("<NAME>")==0)
                        {
                            client.Name = message.Remove(0, 6);
                        }
                        else { 
                            foreach (TcpClient tcpClient in clients)
                            SendMessage(tcpClient, client.Name + ":" + message);
                     }
                        Console.WriteLine(message);
                }           
                }catch (Exception ex) 
                {
                    Console.WriteLine(ex.ToString());
                    return;
                }
            }
        }
        static void Main(string[] args)
        {
            clients = new List<TcpClient>();
            listener = new TcpListener(IPAddress.Any, 8888);
            listener.Start();
            while (true) 
            {
                clients.Add(listener.AcceptTcpClient());
                Console.WriteLine("Hello!");
                Thread thread = new Thread(new ParameterizedThreadStart(ListenClient));
                thread.Start(clients[clients.Count-1]);
            }
        }
    }
}

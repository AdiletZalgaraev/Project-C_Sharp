using System.Net.Sockets;
using System.IO;

namespace ChatLibrary
{
    public static class TcpMessage
    {
        public static void SendMessage(TcpClient tcpClient , string message)
        {
            NetworkStream send_message = tcpClient.GetStream();
            StreamWriter writer = new StreamWriter(send_message);
            writer.WriteLine(message +  "\n");
            writer.Flush();
        }
        public static string GetMessage(TcpClient tcpClient) 
        {
            NetworkStream stream = tcpClient.GetStream();
            StreamReader reader = new StreamReader(stream);
            string message = reader.ReadLine();
            return message;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static ChatLibrary.TcpMessage;

namespace Chat
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Thread thread;
        TcpClient tcpClient;
        public MainWindow()
        {
            InitializeComponent();
            tcpClient = new TcpClient("localhost", 8888);
            Thread thread = new Thread(ListenServer);
            thread.Start();
        }
        public MainWindow(string name)
        {
            
                InitializeComponent();
                tcpClient = new TcpClient("localhost", 8888);
                SendMessage(tcpClient, "<NAME>"+name);
                Thread thread = new Thread(ListenServer);
                thread.Start();
            
        }
        void ListenServer()
        {
            while (true)
            {
                string message = GetMessage(tcpClient);
                if (message != "")
                {
                    Dispatcher.Invoke(() => { His.AppendText(message); });
                }
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SendMessage(tcpClient,messageTextBox.Text);
            messageTextBox.Clear();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            thread.Abort();
        }

        private void messageTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == System.Windows.Input.Key.Enter)
            {
                SendMessage(tcpClient, messageTextBox.Text);
                messageTextBox.Clear();
            }
        }
    }
}

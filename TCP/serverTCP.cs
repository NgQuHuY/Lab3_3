using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace TCP
{
    public partial class serverTCP : Form
    {
        public serverTCP()
        {
            InitializeComponent();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            listViewCommand.Items.Add(new ListViewItem("Server running on 127.0.0.1:8080"));
            listViewCommand.View = View.List;
            CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            serverThread.Start();
        }

        Socket listenerSocket;
        Socket clientSocket;
        
        void StartUnsafeThread()
        {

            listenerSocket = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp
                );
        IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            listenerSocket.Bind(ipepServer);
            listenerSocket.Listen(-1);
            clientSocket = listenerSocket.Accept();

            if (clientSocket.Connected)
            {
                listViewCommand.Items.Add(new ListViewItem("New client connected"));
                Thread listen = new Thread(Receive);
                listen.IsBackground = true;
                listen.Start();
            }

        }

        void Receive()
        {
            while (true)
            {
                try
                {
                    byte[] data = new byte[1024 * 1000];
                    clientSocket.Receive(data);
                    MemoryStream stream = new MemoryStream(data);
                    BinaryFormatter formatter = new BinaryFormatter();

                    string text = (string)formatter.Deserialize(stream);
                    listViewCommand.Items.Add(new ListViewItem(text));
                    listViewCommand.View = View.List;
                }
                catch
                {
                    Close();
                }
            }
           
            
        }
     

        void Close ()
            {
                clientSocket.Close();
            }

    }
}

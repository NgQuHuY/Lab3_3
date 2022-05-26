using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace TCP
{
    public partial class clientTCP : Form
    {
        Socket Client;
        IPEndPoint IP;
        
        public clientTCP()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();

        }
        void Connect()
        {
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            try
            {
                Client.Connect(IP);
            }
            catch
            {
                MessageBox.Show("Khong the ket noi Server !", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }


        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            Send();
        }
        void Send()
        {
            string message = "Hello Server";

            Client.Send(serialize(message));
        }

        byte[] serialize(string obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);

            return stream.ToArray();
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A111223007_UDP_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UdpClient C = new UdpClient();
            int port = int.Parse(textBox4.Text);
            IPEndPoint EP = new IPEndPoint(IPAddress.Parse(textBox3.Text), port);
            C.Connect(EP);
            byte[] B = Encoding.Default.GetBytes(textBox1.Text);
            C.Send(B, B.Length);
            byte[] R = C.Receive(ref EP);
            textBox2.Text = Encoding.Default.GetString(R);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

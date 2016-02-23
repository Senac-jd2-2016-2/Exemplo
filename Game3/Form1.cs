using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Game3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        [STAThread]
        private void btnServidor_Click(object sender, EventArgs e)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, Int32.Parse(txtPortaServer.Text));
            listener.Start();
            TcpClient client = listener.AcceptTcpClient();
            iniciarThread(client, true);
            this.Close();
            using (var game = new Game1()) game.Run();
        }

        [STAThread]
        private void btnCliente_Click(object sender, EventArgs e)
        {
            TcpClient client = new TcpClient(txtIp.Text, Int32.Parse(textPortaClient.Text));
            iniciarThread(client, false);
            this.Close();
            using (var game = new Game1()) game.Run();

        }

        private void iniciarThread(TcpClient client, bool server)
        {
            NetworkStream stream = client.GetStream();

            Thread thread = new Thread(() => {
                ThreadComunicadora threadLeitora = new ThreadComunicadora();
                threadLeitora.stream = stream;
                threadLeitora.server = server;
                threadLeitora.executar();
            });
            thread.Start();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        public static string data = null;       // Testo del client
        public static string ip = "127.0.0.1", port = "5000";

        private void StartListening() {
            int d = 3;
            byte[] bytes = new Byte[1024];

            IPAddress ipAddress = System.Net.IPAddress.Parse(ip);
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, int.Parse(port));

            Socket listener = new Socket(ipAddress.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);

            try {
                
                listener.Bind(localEndPoint);
                listener.Listen(10);

                while (true) {
                    listServer.Items.Add("Aspetto una connessione...");
                    Socket handler = listener.Accept();
                    data = null;

                    while (true) {
                        int bytesRec = handler.Receive(bytes);
                        data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                        if (data.IndexOf("<EOF>") > -1) {
                            break;
                        }
                    }

                    listServer.Items.Add("Testo ricevuto : " + data);

                    int n = new Random().Next(1, 9);
                    switch (d) {
                        case 1:
                            n = new Random().Next(1, 9);
                            break;
                        case 2:
                            n = new Random().Next(1, 19);
                            break;
                        case 3:
                            n = new Random().Next(1, 29);
                            break;
                    }

                    listServer.Items.Add("Ritorno: " + n);

                    handler.Send(Encoding.ASCII.GetBytes(n.ToString()));
                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }

            }
            catch (Exception e) {
                listServer.Items.Add(e.ToString());
            }

            listServer.Items.Add("\nPress ENTER to continue...");
        }
        private void btn_start_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(StartListening));
            t.Start();
        }
    }
}

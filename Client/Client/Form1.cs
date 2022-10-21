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

namespace Client {
    public partial class Form1 : Form {
        int num;
        string ip = "127.0.0.1", port = "5000";
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            lbl_result.Text = "";
        }

        private void btn_send_Click_1(object sender, EventArgs e) {
            try
            {
                num = int.Parse(txt_number.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Devi inserire un numero per giocare");
            }

            lbl_result.Text = "";

            // Set socket
            byte[] bytes = new byte[1024];
            try
            {
                IPAddress ipAddress = System.Net.IPAddress.Parse(ip);
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, int.Parse(port));

                Socket Sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    Sender.Connect(remoteEP);
                    // MessageBox.Show("Connesso con " + Sender.RemoteEndPoint.ToString());
                    byte[] msg = Encoding.ASCII.GetBytes(num + "<EOF>");
                    int bytesSent = Sender.Send(msg);

                    int bytesRec = Sender.Receive(bytes);
                    string response = Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    // MessageBox.Show("Risposta del server: " + response);
                    lbl_result.Text += response;

                    if (int.Parse(response) == num)
                    {
                        lbl_result.Text = "Hai vinto 🥳";
                    }
                    else
                    {
                        lbl_result.Text = "Hai perso 😢";
                    }

                    Sender.Shutdown(SocketShutdown.Both);
                    Sender.Close();
                }
                catch (ArgumentNullException ane)
                {
                    MessageBox.Show("Errore: riprova");
                }
                catch (SocketException se)
                {
                    MessageBox.Show("Errore: prova con un altro IP");
                }
                catch (Exception)
                {
                    MessageBox.Show("Errore: riprova");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

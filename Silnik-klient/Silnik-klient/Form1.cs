using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;


/*Metoda działania klienta. Klient łączy się z serwerem w sieci lokalnej. Serwerów może być kilka, to gdzie trafi polecenie zależy
od portu. Polecenia poprzedzamy znakiem specjalnym "#". Lista komend wyświetlana jest odpowiednim przyciskiem */



namespace Silnik_klient
{
    public partial class Form1 : Form
    {

        string adres = "81";
        Socket sck;
        EndPoint ipSerwer, ipKlient; 
        byte[] buffer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Podstawowe ustawienia socketu oraz pobieranie adresu ip

            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            ip_textbox.Text = GetLocalIP();

        }
        
        private string GetLocalIP()
        {
            //Pobieranie adresu sieci lokalnej

            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            }
            return "192.168.0.1";
        }

     
        private void connect_butotn_Click(object sender, EventArgs e)
        {
            //parowanie klienta z sewerem

            ipKlient = new IPEndPoint(IPAddress.Parse(ip_textbox.Text), Convert.ToInt32(80));
            sck.Bind(ipKlient);
            ipSerwer = new IPEndPoint(IPAddress.Parse(ip_textbox.Text), Convert.ToInt32(port_textbox.Text));
            sck.Connect(ipSerwer);

            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref ipKlient, new AsyncCallback(MessageCallBack), buffer);       
           
        }

       
        private void button1_Click(object sender, EventArgs e)
        {

            //wysylanie wiadomosci

            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];

            if (message_textbox.Text == " ")
            {
                MessageBox.Show("Wpisz komende");
            }

            else
            {
                sendingMessage = aEncoding.GetBytes(message_textbox.Text);
                sck.Send(sendingMessage);
                message_textbox.Text = "";
            }

        }

        private void port_textbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                byte[] receivedData = new byte[1500];
                receivedData = (byte[])aResult.AsyncState;
                //zamiana na string
                ASCIIEncoding aEncoding = new ASCIIEncoding();
                string receivedmessage = aEncoding.GetString((receivedData));

               

                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref ipKlient, new AsyncCallback(MessageCallBack), buffer);
                MessageBox.Show(receivedmessage);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void pStob_Click(object sender, EventArgs e)
        {
            message_textbox.Text = "prawo 100";
        }

        private void pDzib_Click(object sender, EventArgs e)
        {
            message_textbox.Text = "prawo 10";
        }

        private void mDzieb_Click(object sender, EventArgs e)
        {
            message_textbox.Text = "lewo 10";
        }

        private void mStob_Click(object sender, EventArgs e)
        {
            message_textbox.Text = "lewo 100";
        }




    }
}

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


/*
 * 
 * Wywalić pętlę
 * komunikaty timera
 * kolejkownaie polece
 * komunnikat paint */

namespace Silnik_serwer_mk2
{
    public partial class Form1 : Form
    {
        //ZMIENNE 

        Socket sck;
        EndPoint ipSerwer, ipKlient;
        byte[] buffer;
        bool stan = true;
       
        Rectangle rec, tlo;
        Graphics graf, tloGrafika;
        Timer t = new Timer();
        List<int> listaPolecen = new List<int>();


        int x = 0;
        int y = 0;
        int move_x = 0;
        int move_y = 0;
        int koniec = 0;
        int polecenie = 0;
        int polozenie = 0;
        


        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            tlo = new Rectangle(10, 10, 200, 200);
            graf = this.CreateGraphics();
            tloGrafika = this.CreateGraphics();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            t.Interval = 2;
            t.Tick += new EventHandler(t_Tick);
            t.Start();

        }


        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            }
            return "192.168.1.0";
        }

        private void connect_button_Click(object sender, EventArgs e)
        {
            //Łączenie socketów
            ipSerwer = new IPEndPoint(IPAddress.Parse(GetLocalIP()), 81);
            sck.Bind(ipSerwer);
            
            ipKlient = new IPEndPoint(IPAddress.Parse(GetLocalIP()), 80);
            sck.Connect(ipKlient);
            
            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref ipKlient, new AsyncCallback(MessageCallBack), buffer);


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
                
                //Dodanie polecenia do listy

                string[] podzielonaKomenda = podzielnikKomendy(receivedmessage);
                listaPolecenBox.Items.Add(interpreter(podzielonaKomenda[0], podzielonaKomenda[1]));

             
                string rozkaz = listaPolecenBox.Items[0].ToString();
                int intRoznaz = Convert.ToInt32(rozkaz);
                polecenie = intRoznaz;
                    
       
                
    
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        
        
        private string[] podzielnikKomendy(string polecenie)
        {
            Char podzielnik = ' ';
            String[] substrings = polecenie.Split(podzielnik);
 
            return substrings; //komenda podzielona na tablice

        }

        private int interpreter(string kierunek, string obrot)
        {

            int kod = 0;
            string pierwszyCzlon = kierunek;
            int wartosc = Convert.ToInt32(obrot);
            

            if (pierwszyCzlon == "prawo")
            {
                    kod = wartosc;               
            }

            if (pierwszyCzlon == "lewo")
            {
                    kod = wartosc * -1;           
            }


            if (pierwszyCzlon != "prawo" & pierwszyCzlon != "lewo")
            {
                string wiadomosc = "Bledna skladnia";

                ASCIIEncoding aEncoding = new ASCIIEncoding();
                byte[] sendingMessage = new byte[1500];
                sendingMessage = aEncoding.GetBytes(wiadomosc);
                sck.Send(sendingMessage);
            }
          

            return kod;
        }

        void t_Tick(object sender, EventArgs e)
        {


            graf.Clear(BackColor);
            tloGrafika.DrawRectangle(System.Drawing.Pens.Red, tlo);

            Convert.ToInt32(polecenie);

            if (polecenie > 0)
            {
                koniec = polozenie + polecenie;
                move_x += 1;
                if (move_x == koniec)
                {
                    polecenie = 0;
                    polozenie = koniec;
                    listaPolecenBox.Items.RemoveAt(0);
                }
                    
                
            }

            if (polecenie < 0)
            {
                koniec = polozenie + polecenie -10 ;
                move_x += -1;
   
                if (move_x == koniec)
                {
                    polecenie = 0;
                    polozenie = koniec;
                    listaPolecenBox.Items.RemoveAt(0);
                }
            }


            graf.DrawPie(System.Drawing.Pens.Blue, tlo,move_x,2);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            polecenie = 30;
        }

    }
}

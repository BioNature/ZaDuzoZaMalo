using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIgra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int RandomNumber;
        private int od;
        private int doo;
        bool pauza = false;
        private System.Timers.Timer time1;

        int s, m, h;

        private void StartTimer()
        {
            time1 = new System.Timers.Timer();
            time1.Interval = 1000;
            time1.Elapsed += OnTimeEvent;
            time1.AutoReset = true;
            time1.Enabled = true;
        }

        private void NowaGra_Click(object sender, EventArgs e)
        {
            GroupBoxLosuj.Visible = true;
            NowaGra.Enabled = false;
            Sprawdz.Enabled = false;
            Historia.Enabled = false;
            Zgadywana.Enabled = false;
            Pauza.Enabled = false;
            Komentarz.Visible = false;
            WylosowanaLiczba.Visible = false;
            LiczbaProb.Visible = false;
            Czasomierz.Visible = false;
            Od.Enabled = true;
            Do.Enabled = true;
            Wylosuj.Enabled = true;
            s = 0;
            m = 0;
            h = 0;
            Czasomierz.Text = "00:00:00";
        }

        private void Wylosuj_Click(object sender, EventArgs e)
        {
            od = Convert.ToInt16(Od.Text);
            doo = Convert.ToInt16(Do.Text);

            Random Losowanie = new Random();

            RandomNumber = Losowanie.Next(od, doo);

            Od.Enabled = false;
            Do.Enabled = false;
            Wylosuj.Enabled = false;
            Zgadywana.Enabled = true;
            Pauza.Enabled = true;
            pauza = true;
            Sprawdz.Enabled = true;
            Historia.Enabled = true;
            Czasomierz.Visible = true;
            StartTimer();
        }

        private void Sprawdz_Click(object sender, EventArgs e)
        {
            string number = " ";
            bool isNumber = false;
            int ConNumber = 0;
            try
            {
                number = Zgadywana.Text;
                isNumber = int.TryParse(number, out ConNumber);
                Komentarz.Text = "Proszę podać liczbę!";
                Komentarz.ForeColor = Color.Black;

            }
            catch (InvalidCastException ex)
            {
                throw;
            }

            if (isNumber)
            {
                if (ConNumber > RandomNumber)
                {
                    Komentarz.Text = "To Big";
                    Komentarz.ForeColor = Color.Red;

                }
                else if (ConNumber < RandomNumber)
                {
                    Komentarz.Text = "To Small";
                    Komentarz.ForeColor = Color.Red;
                }
                else
                {
                    Komentarz.Text = "Correct";
                    Komentarz.ForeColor = Color.Green;
                    time1.Dispose();
                    NowaGra.Enabled = true;
                    Pauza.Enabled = false;
                    Sprawdz.Enabled = false;
                    Zgadywana.Enabled = false;
                }
            }
            isNumber = false;

            Komentarz.Visible = true;
        }

        private void Pauza_Click(object sender, EventArgs e)
        {
            if(pauza)
            {
                Pauza.Text = "Wznów";
                Sprawdz.Enabled = false;
                Zgadywana.Enabled = false;
                pauza = false;
                time1.Stop();
            }
            else 
            {
                Pauza.Text = "Pauza";
                Sprawdz.Enabled = true;
                Zgadywana.Enabled = true;
                pauza = true;
                time1.Start();
            }
        }

        private void Historia_Click(object sender, EventArgs e)
        {

        }

        private void Informacje_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor: Sebastian Żak \nProjekt Zaliczeniowy na Labolatoria");
        }

        private void Od_MouseClick(object sender, MouseEventArgs e)
        {
            Od.Text = " ";
        }

        private void Do_MouseClick(object sender, MouseEventArgs e)
        {
            Do.Text = " ";
        }

        private void OnTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s += 1;
                if (s == 60)
                {
                    s = 0;
                    m += 1;
                }
                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }
                Czasomierz.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2,'0')) ;
            }));
        }

        private void Zgadywana_MouseClick(object sender, MouseEventArgs e)
        {
            Zgadywana.Text = " ";
        }
    }
}

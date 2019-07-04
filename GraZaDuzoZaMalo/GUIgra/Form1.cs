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
        int czas = 0;

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
            czas = 0;
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
            Sprawdz.Enabled = true;
            Historia.Enabled = true;
            timer1.Start();
            Czasomierz.Visible = true;

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
                    timer1.Stop();
                    NowaGra.Enabled = true;
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
                Od.Enabled = false;
                Do.Enabled = false;
                Sprawdz.Enabled = false;
                Zgadywana.Enabled = false;
                Wylosuj.Enabled = false;
                pauza = false;
                timer1.Stop();
            }
            else
            {
                Pauza.Text = "Pauza";
                Od.Enabled = true;
                Do.Enabled = true;
                Sprawdz.Enabled = true;
                Zgadywana.Enabled = true;
                Wylosuj.Enabled = true;
                pauza = true;
                timer1.Start();
            }
        }

        private void Historia_Click(object sender, EventArgs e)
        {

        }

        private void Informacje_Click(object sender, EventArgs e)
        {

        }

        private void Od_MouseClick(object sender, MouseEventArgs e)
        {
            Od.Text = " ";
        }

        private void Do_MouseClick(object sender, MouseEventArgs e)
        {
            Do.Text = " ";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            czas++;
            Czasomierz.Text = "Czas gry " + czas;
        }

        private void Zgadywana_MouseClick(object sender, MouseEventArgs e)
        {
            Zgadywana.Text = " ";
        }
    }
}

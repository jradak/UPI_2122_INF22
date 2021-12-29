using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skladiste_HMR
{
    public partial class Form2 : Form
    {
        public Form2(string kime, string uloga)
        {
            InitializeComponent();
            lblKorIme.Text = kime;
            if (uloga == "admin")
            {
                picBox_Korisnici.Show();
                picBox_Planer.Hide();
                picBox_Skladiste.Hide();
                picBox_Proizvodi.Hide();
            }
            else
            {
                picBox_Korisnici.Hide();
                picBox_Planer.Show();
                picBox_Skladiste.Show();
                picBox_Proizvodi.Show();
            }
        }

        private void picBox_Planer_Click(object sender, EventArgs e)
        {
            Form4 fm4 = new Form4();
            fm4.Show();
        }

        private void picBox_Planer_MouseHover(object sender, EventArgs e)
        {
            Sjena1.Show();
            lblInfoOdabir.Show();
            lblInfoOdabir.Text = "Planer";
        }

        private void picBox_Planer_MouseLeave(object sender, EventArgs e)
        {
            Sjena1.Hide();
            lblInfoOdabir.Hide();
        }

        private void picBox_Skladiste_MouseHover(object sender, EventArgs e)
        {
            Sjena2.Show();
            lblInfoOdabir.Show();
            lblInfoOdabir.Text = "Skladište";
        }

        private void picBox_Skladiste_MouseLeave(object sender, EventArgs e)
        {
            Sjena2.Hide();
            lblInfoOdabir.Hide();
        }
        private void picBox_Skladiste_Click(object sender, EventArgs e)
        {
            Sjena2.Show();
            lblInfoOdabir.Show();
            lblInfoOdabir.Text = "Skladište";
            //ovo je samo primjer
            Form3 fm3 = new Form3();
            fm3.Show();
        }

        private void picBox_Proizvodi_MouseLeave(object sender, EventArgs e)
        {
            Sjena3.Hide();
            lblInfoOdabir.Hide();
        }

        private void picBox_Proizvodi_MouseHover(object sender, EventArgs e)
        {
            Sjena3.Show();
            lblInfoOdabir.Show();
            lblInfoOdabir.Text = "Proizvodi";
        }

        

        private void picBox_Proizvodi_Click(object sender, EventArgs e)
        {
            Sjena3.Show();
            lblInfoOdabir.Show();
            lblInfoOdabir.Text = "Proizvodi";
            Form5 fm5 = new Form5();
            fm5.Show();
        }

        private void picBox_Korisnici_MouseHover(object sender, EventArgs e)
        {
            Sjena2.Show();
            lblInfoKorR.Show();
        }
        private void picBox_Korisnici_MouseLeave(object sender, EventArgs e)
        {

            Sjena2.Hide();
            lblInfoKorR.Hide();
        }
        private void picBox_Korisnici_Click(object sender, EventArgs e)
        {
            Sjena2.Show();
            lblInfoKorR.Show();
            Form6 fm6 = new Form6();
            fm6.Show();
        }
        
        private void btnOdjava_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
            GC.Collect();
            Form1 fm1 = new Form1();
            fm1.Show();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

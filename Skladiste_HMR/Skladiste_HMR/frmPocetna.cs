using System;
using System.Windows.Forms;

namespace Skladiste_HMR
{
    public partial class frmPocetna : Form
    {
        Korisnik korisnik;

        public frmPocetna(Korisnik k)
        {
            korisnik = k;
            InitializeComponent();
            lblKorIme.Text = korisnik.Ime;
            if (korisnik.Uloga == "admin")
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
            frmPlaner planer = new frmPlaner(korisnik);
            planer.ShowDialog();
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
            frmSkladiste skladiste = new frmSkladiste(korisnik);
            skladiste.ShowDialog();
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
            frmProizvodi proizvodi = new frmProizvodi(korisnik);
            proizvodi.ShowDialog();
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
            frmKorisnici korisnici = new frmKorisnici();
            korisnici.ShowDialog();
        }
        
        private void btnOdjava_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
            //prisilni garbage collecition 
            GC.Collect();
            frmPrijava prijava = new frmPrijava();
            prijava.ShowDialog();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

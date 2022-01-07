using System;
using System.Windows.Forms;

namespace Skladiste_HMR
{
    public partial class frmPrijava : Form
    {
        Korisnik korisnik = new Korisnik(-1, null, null, null, null, null);
        public frmPrijava()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            string kIme = tbKIme.Text;
            string lozinka = tbLozinka.Text;
         
            if (kIme == "" || lozinka == "") 
            {
                MessageBox.Show("Niste popunili sva polja! Pokušajte ponovno!");
                return;
            }
            try
            {
                bool korisnikPostoji = korisnik.PostojanostKorisnika(kIme, lozinka);
                if (korisnikPostoji)
                {
                    string[] nizPodataka = korisnik.DohvatiPodatkeZaPrijavu(kIme, lozinka);

                    korisnik = new Korisnik(int.Parse(nizPodataka[0]), nizPodataka[1], nizPodataka[2],
                        nizPodataka[3], nizPodataka[4], nizPodataka[5]);
                    MessageBox.Show("Usješno ste se prijavili!");
                    this.Hide();
                    frmPocetna pocetna = new frmPocetna(korisnik);
                    pocetna.Show();
                }
                else
                {
                    MessageBox.Show("Prijava je neuspješna, pokušajte ponovno!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

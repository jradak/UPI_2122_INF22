using System;
using System.Windows.Forms;


namespace Skladiste_HMR
{
    public partial class frmKorisnici : Form
    {
        Korisnik korisnik = new Korisnik(-1, null, null, null, null, null);

        public frmKorisnici()
        {
            InitializeComponent();
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            CiscenjeProzora();
            btnBrisiKor.Hide();
            btnUrediKor.Hide();
            try
            {
                korisnik.PrikazKorisnika(dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CiscenjeProzora();
            btnBrisiKor.Show();
            btnUrediKor.Show();
            korisnik.Id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            korisnik.Ime = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            korisnik.Prezime = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            korisnik.KorisnickoIme = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            korisnik.Lozinka = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            korisnik.Uloga = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnDodajKor_Click(object sender, EventArgs e)
        {
            IsprazniBox();
            PopuniProzor("dodavanje");
        }

        private void btnUrediKor_Click(object sender, EventArgs e)
        {
            txtIme.Text = korisnik.Ime;
            txtPrezime.Text = korisnik.Prezime;
            txtKorIme.Text = korisnik.KorisnickoIme;
            txtLozinka.Text = korisnik.Lozinka;
            cmbBoxUloga.Text = korisnik.Uloga;
            PopuniProzor("uredivanje");
        }

        private void btnSpremiKor_Click(object sender, EventArgs e)
        {
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            string korisnickoIme = txtKorIme.Text;
            string lozinka = txtLozinka.Text;
            

            if (cmbBoxUloga.SelectedIndex > -1 && Provjere.ProvjeraUnosa(ime) && Provjere.ProvjeraUnosa(prezime)
                && Provjere.ProvjeraKorImena(korisnickoIme) && Provjere.ProvjeraLozinke(lozinka))
            {
                string uloga = cmbBoxUloga.SelectedItem.ToString();
                korisnik.DodavanjeKorisnika(ime, prezime, korisnickoIme, lozinka, uloga);
                MessageBox.Show("Uspješno ste unijeli novog korisnika!");
                korisnik.PrikazKorisnika(dataGridView1);
                CiscenjeProzora();
                IsprazniBox();
            }
            else
            {
                MessageBox.Show("Niste popunili ispravno sva polja. Pokušajte ponovno!");
            }
        }

        private void btnPromijeniKor_Click(object sender, EventArgs e)
        {
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            string korisnickoIme = txtKorIme.Text;
            string lozinka = txtLozinka.Text;
            string uloga = cmbBoxUloga.SelectedItem.ToString();

            if (cmbBoxUloga.SelectedIndex > -1 && Provjere.ProvjeraUnosa(ime) && Provjere.ProvjeraUnosa(prezime)
                && Provjere.ProvjeraKorImena(korisnickoIme) && Provjere.ProvjeraLozinke(lozinka))
            {
                korisnik.UredivanjeKorisnika(korisnik.Id, ime, prezime, korisnickoIme, lozinka, uloga);
                MessageBox.Show("Uspješno ste promijenili podatke o korisniku!");
                korisnik.PrikazKorisnika(dataGridView1);
                CiscenjeProzora();
                IsprazniBox();
            }
            else
            {
                MessageBox.Show("Neispravno mijenjanje! Pokušajte ponovno!");
            }
        }

        private void btnBrisiKor_Click(object sender, EventArgs e)
        {
            if (korisnik.Id != -1)
            {
                korisnik.BrisanjeKorisnika(korisnik.Id);
                MessageBox.Show("Uspješno izbrisan korisnički račun!");
                korisnik.PrikazKorisnika(dataGridView1);
                CiscenjeProzora();
            }
            else
            {
                MessageBox.Show("Odaberite korisnički račun za brisanje!");
            }
        }
        
        private void PopuniProzor(string vrsta)
        {
            if (vrsta == "dodavanje")
            {
                btnSpremiKor.Show();
                btnPromijeniKor.Hide();
            }
            else if (vrsta == "uredivanje")
            {
                btnSpremiKor.Hide();
                btnPromijeniKor.Show();
            }
            txtIme.Show();
            txtPrezime.Show();
            txtKorIme.Show();
            txtLozinka.Show();
            cmbBoxUloga.Show();

            lblIme.Show();
            lblPrezime.Show();
            lblKorIme.Show();
            lblLozinka.Show();
            lblUloga.Show();

            label1.Show();

        }
        private void CiscenjeProzora()
        {
            korisnik.Id = -1;
            btnSpremiKor.Hide();
            btnPromijeniKor.Hide();
            txtIme.Hide();
            txtPrezime.Hide();
            txtKorIme.Hide();
            txtLozinka.Hide();
            cmbBoxUloga.Hide();
            lblIme.Hide();
            lblPrezime.Hide();
            lblKorIme.Hide();
            lblLozinka.Hide();
            lblUloga.Hide();
            btnBrisiKor.Hide();
            btnUrediKor.Hide();
            label1.Hide();
        }
        private void IsprazniBox()
        {
            txtIme.Text = "";
            txtPrezime.Text = "";
            txtKorIme.Text = "";
            txtLozinka.Text = "";
            cmbBoxUloga.Text = "";
        }
    }
}

using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Skladiste_HMR
{
    public partial class Form6 : Form
    {
        int ID = -1;
        string defIme = "";
        string defPrezime = "";
        string defKorIme = "";
        string defLozinka = "";
        string defUloga = "";
        SqlConnection con = new SqlConnection(Konstante.ConnectionString);
        SqlCommand cmd;
        SqlDataAdapter adapt;

        public Form6()
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
                DisplayData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CiscenjeProzora();
            btnBrisiKor.Show();
            btnUrediKor.Show();
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            defIme = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            defPrezime = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            defKorIme = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            defLozinka = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            defUloga = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnDodajKor_Click(object sender, EventArgs e)
        {
            IsprazniBox();
            PopuniProzor("dodavanje");
        }

        private void btnUrediKor_Click(object sender, EventArgs e)
        {
            txtIme.Text = defIme;
            txtPrezime.Text = defPrezime;
            txtKorIme.Text = defKorIme;
            txtLozinka.Text = defLozinka;
            cmbBoxUloga.Text = defUloga;
            PopuniProzor("uredivanje");
        }

        private void btnSpremiKor_Click(object sender, EventArgs e)
        {
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            string korisnickoIme = txtKorIme.Text;
            string lozinka = txtLozinka.Text;
            string uloga = cmbBoxUloga.SelectedItem.ToString();

            if (uloga.Length > 0 && provjeraUnosa(ime) && provjeraUnosa(prezime)
                && provjeraKorImena(korisnickoIme) && provjeraLozinke(lozinka))
            {
                cmd = new SqlCommand("insert into Korisnik(Ime, Prezime, KorisnickoIme, Lozinka, Uloga)" +
                    " values(@ime, @prezime, @kIme, @lozinka, @uloga)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@ime", ime);
                cmd.Parameters.AddWithValue("@prezime", prezime);
                cmd.Parameters.AddWithValue("@kIme", korisnickoIme);
                cmd.Parameters.AddWithValue("@lozinka", lozinka);
                cmd.Parameters.AddWithValue("@uloga", uloga);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Uspješno ste unijeli novog korisnika!");
                DisplayData();
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

            if (cmbBoxUloga.SelectedIndex > -1 && provjeraUnosa(ime) && provjeraUnosa(prezime)
                && provjeraKorImena(korisnickoIme) && provjeraLozinke(lozinka))
            {
                cmd = new SqlCommand("update Korisnik set Ime=@ime,Prezime=@prezime, KorisnickoIme=@kIme, " +
                    "Lozinka=@lozinka,Uloga=@uloga where ID_Korisnik=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@ime", ime);
                cmd.Parameters.AddWithValue("@prezime", prezime);
                cmd.Parameters.AddWithValue("@kIme", korisnickoIme);
                cmd.Parameters.AddWithValue("@lozinka", lozinka);
                cmd.Parameters.AddWithValue("@uloga", uloga);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Uspješno ste promijenili podatke o korisniku!");
                con.Close();
                DisplayData();
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
            if (ID != -1)
            {
                cmd = new SqlCommand("delete Korisnik where ID_Korisnik=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Uspješno izbrisan korisnički račun!");
                DisplayData();
                CiscenjeProzora();
            }
            else
            {
                MessageBox.Show("Odaberite korisnički račun za brisanje!");
            }
        }
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Korisnik", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        
        private bool provjeraUnosa(string unos)
        {
            if (unos.Length < 3)
            {
                return false;
            }
            if (!Char.IsLetter(unos, 0) || Char.IsLower(unos, 0))
            {
                return false;
            }
            for (int i = 1; i < unos.Length; i++)
            {
                if (!Char.IsLetter(unos, i) || Char.IsUpper(unos, i))
                {
                    return false;
                }
            }

            return true;
        }
        private bool provjeraKorImena(string unos)
        {
            if (unos.Length < 3)
            {
                return false;
            }
            foreach (char znak in unos)
            {
                if (!Char.IsLetterOrDigit(znak) || Char.IsUpper(znak))
                {
                    return false;
                }
            }
            return true;
        }
        private bool provjeraLozinke(string unos)
        {
            if (unos.Length < 7)
            {
                return false;
            }
            return true;
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
            ID = -1;
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

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
            btnBrisiKor.Hide();
            btnUrediKor.Hide();
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
            try
            {
                SqlConnection con = new SqlConnection(Konstante.ConnectionString);
                SqlCommand cmd = new SqlCommand("Select * from Korisnik", con);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                //close connection
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnBrisiKor.Show();
            btnUrediKor.Show();
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
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            defIme = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            defPrezime = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            defKorIme = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            defLozinka = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            defUloga = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnDodajKor_Click(object sender, EventArgs e)
        {
            txtIme.Show();
            txtPrezime.Show();
            txtKorIme.Show();
            txtLozinka.Show();
            cmbBoxUloga.Show();
            btnSpremiKor.Show();
            btnPromijeniKor.Hide();

            lblIme.Show();
            lblPrezime.Show();
            lblKorIme.Show();
            lblLozinka.Show();
            lblUloga.Show();

            txtIme.Text = "";
            txtPrezime.Text = "";
            txtKorIme.Text = "";
            txtLozinka.Text = "";
        }

        private void btnUrediKor_Click(object sender, EventArgs e)
        {
            txtIme.Show();
            txtPrezime.Show();
            txtKorIme.Show();
            txtLozinka.Show();
            cmbBoxUloga.Show();
            btnSpremiKor.Hide();
            btnPromijeniKor.Show();

            lblIme.Show();
            lblPrezime.Show();
            lblKorIme.Show();
            lblLozinka.Show();
            lblUloga.Show();

            txtIme.Text = defIme;
            txtPrezime.Text = defPrezime;
            txtKorIme.Text = defKorIme;
            txtLozinka.Text = defLozinka;
            cmbBoxUloga.Text = defUloga;
        }

        private void btnSpremiKor_Click(object sender, EventArgs e)
        {
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            string korisnickoIme = txtKorIme.Text;
            string lozinka = txtLozinka.Text;
            string uloga = cmbBoxUloga.SelectedItem.ToString();

            if (cmbBoxUloga.SelectedIndex > -1 && provjeraUnosa(ime) && provjeraUnosa(prezime)
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
                ClearData();

                txtIme.Text = "";
                txtPrezime.Text = "";
                txtKorIme.Text = "";
                txtLozinka.Text = "";
                cmbBoxUloga.Text = "";
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
                ClearData();
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
                ClearData();
            }
            else
            {
                MessageBox.Show("please select record to delete");
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
        private void ClearData()
        {
            ID = -1;
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
    }
}

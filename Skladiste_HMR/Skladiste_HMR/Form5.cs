using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Skladiste_HMR
{
    public partial class Form5 : Form
    {

        string ulogaGlob = "";
        SqlConnection con = new SqlConnection(Konstante.ConnectionString);
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int ID = -1;
        string defProizvod = "";
        string defCijena = "";
        double cijena_def = 0;
        string valuta_def = "";
        public Form5(string uloga)
        {
            ulogaGlob = uloga;
            InitializeComponent();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            CiscenjeProzora();
            btnBrisiPr.Hide();
            btnUrediPr.Hide();
            if (ulogaGlob == "radnik")
            {
                btnDodajPr.Hide();
            }
            try
            {
                DisplayData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (ulogaGlob == "poslovoda")
            {
                btnBrisiPr.Show();
                btnUrediPr.Show();
                CiscenjeProzora();
                IsprazniBox();
            }
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            defProizvod = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            defCijena = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            PodjelaCijene();
        }

        private void btnBrisiPr_Click(object sender, EventArgs e)
        {
            if (ID != -1)
            {
                cmd = new SqlCommand("delete Proizvod where ID_Proizvod=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Uspješno izbrisan proizvod!");
                DisplayData();
                CiscenjeProzora();
            }
            else
            {
                MessageBox.Show("Odaberite proizvod za brisanje!");
            }
        }

        private void btnDodajPr_Click(object sender, EventArgs e)
        {
            PopunjavanjeProzora();
            btnSpremiPr.Show();
            btnPromijeniPr.Hide();

            IsprazniBox();
        }

        private void btnUrediPr_Click(object sender, EventArgs e)
        {
            PopunjavanjeProzora();
            btnPromijeniPr.Show();
            btnSpremiPr.Hide();

            txtNazivPr.Text = defProizvod;
            txtCijenaPr.Text = cijena_def.ToString();
            cmbBoxValuta.Text = valuta_def;
        }

        private void btnPromijeniPr_Click(object sender, EventArgs e)
        {
            string proizvod = txtNazivPr.Text;
            string cijena = txtCijenaPr.Text;
            string valuta = cmbBoxValuta.SelectedItem.ToString();

            if (valuta.Length > 0 && ProvjeraUnosa(proizvod) && ProvjeraCijene(cijena))
            {
                if (cijena.IndexOf('.') != -3 || cijena.IndexOf(',') != -3)
                {
                    cijena += '0';
                }

                cmd = new SqlCommand("update Proizvod set Naziv=@naziv, Cijena=@cijena" +
                    " where ID_Proizvod=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@naziv", proizvod);
                cmd.Parameters.AddWithValue("@cijena", cijena + " " + valuta);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Uspješno ste promijenili podatke o proizvodu!");
                DisplayData();
                CiscenjeProzora();
                IsprazniBox();
            }
            else
            {
                MessageBox.Show("Niste popunili ispravno sva polja. Pokušajte ponovno!");
            }
        }

        private void btnSpremiPr_Click(object sender, EventArgs e)
        {
            string proizvod = txtNazivPr.Text;
            string cijena = txtCijenaPr.Text;
            string valuta = cmbBoxValuta.SelectedItem.ToString();

            if (valuta.Length > 0 && ProvjeraUnosa(proizvod) && ProvjeraCijene(cijena))
            {
                if (cijena.IndexOf('.') != -3 || cijena.IndexOf(',') != -3)
                {
                    cijena += '0';
                }
                cmd = new SqlCommand("insert into Proizvod(Naziv, Cijena)" +
                    " values(@naziv, @cijena)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@naziv", proizvod);
                cmd.Parameters.AddWithValue("@cijena", cijena+" "+valuta);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Uspješno ste unijeli novi proizvod!");
                DisplayData();
                CiscenjeProzora();
                IsprazniBox();
            }
            else
            {
                MessageBox.Show("Niste popunili ispravno sva polja. Pokušajte ponovno!");
            }
        }
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("Select * from Proizvod", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void CiscenjeProzora()
        {
            ID = -1;
            btnSpremiPr.Hide();
            btnPromijeniPr.Hide();
            txtNazivPr.Hide();
            txtCijenaPr.Hide();
            lblNazivPr.Hide();
            lblCijenaPr.Hide();
            cmbBoxValuta.Hide();
            lblValuta.Hide();
        }
        private void PopunjavanjeProzora()
        {
            txtNazivPr.Show();
            txtCijenaPr.Show();
            lblNazivPr.Show();
            lblCijenaPr.Show();
            cmbBoxValuta.Show();
            lblValuta.Show();
        }
        private void IsprazniBox()
        {
            txtNazivPr.Text = "";
            txtCijenaPr.Text = "";
            cmbBoxValuta.Text = "";
        }
        private void PodjelaCijene()
        {
            string pomocna = "";
            foreach (char znak in defCijena)
            {
                if (Char.IsDigit(znak) || znak == '.' || znak == ',')
                {
                    if (znak == '.')
                    {
                        pomocna += ',';
                    }
                    else
                    {
                        pomocna += znak;
                    }
                }
                if (znak=='H' || znak == 'R' || znak == 'K' || znak== '€')
                {
                    valuta_def+=znak;
                }
            }
            cijena_def = double.Parse(pomocna);
        }

        private bool ProvjeraUnosa(string unos)
        {
            if (unos.Length < 3 || unos.Length > 50)
            {
                return false;
            }
            return true;
        }
        private bool ProvjeraCijene(string cijena)
        {
            if (cijena.Length < 1)
            {
                return false;
            }
            double pomocna = 0;
            bool uspjeh = double.TryParse(cijena, out pomocna);
            if (!uspjeh)
            {
                return false;
            }
            return true;
        }
    }
}

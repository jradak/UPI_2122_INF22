using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Skladiste_HMR
{
    public partial class frmIsporuke : Form
    {
        string ID_Narudzba = "";
        SqlConnection con = new SqlConnection(Konstante.ConnectionString);
        SqlCommand cmd;
        SqlDataAdapter adapt;
        
        public frmIsporuke(string id_n)
        {
            ID_Narudzba = id_n;
            InitializeComponent();
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            txtIdNarudzba.Text = ID_Narudzba.ToString();

            CiscenjeProzora();
            
            btnBrisiIsp.Hide();

            btnUrediIsp.Hide();

            try
            {
                DisplayDataIsporuke(ID_Narudzba);
                DisplayDataProizvodi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CiscenjeProzora()
        {
            btnSpremiIsp.Hide();
            btnPromijeniIsp.Hide();
            btnOdaberiPr.Hide();
            lblIdNarudzba.Hide();
            txtIdNarudzba.Hide();
            lblDatum.Hide();
            lblKolicinaPr.Hide();
            lblSektor.Hide();
            lblProizvod.Hide();
            lblIdProizvod.Hide();
            txtSektor.Hide();
            dateTimePicker1.Hide();
            txtKolicinaPr.Hide();
            dataGridViewPr.Hide();
        }
        private void PopunjavanjeProzora()
        {
            btnOdaberiPr.Show();
            lblIdNarudzba.Show();
            txtIdNarudzba.Show();
            lblDatum.Show();
            lblKolicinaPr.Show();
            lblSektor.Show();
            lblProizvod.Show();
            lblIdProizvod.Show();
            txtSektor.Show();
            dateTimePicker1.Show();
            txtKolicinaPr.Show();
        }

        private void IsprazniBox()
        {
            dateTimePicker1.Value = DateTime.Now;
            txtKolicinaPr.Text = "";
            txtIdProizvod.Text = "";
        }

        private void DisplayDataIsporuke(string id_nar)
        {
            int narudzba = int.Parse(id_nar);
            cmd = new SqlCommand("Select Isporuka.ID_Isporuka, Isporuka.Kolicina, Isporuka.Datum, " +
            "Proizvod.Naziv, Proizvod.Cijena, Isporuka.ID_Narudzba from Isporuka inner join Proizvod " +
            "on Isporuka.ID_Proizvod=Proizvod.ID_Proizvod where Isporuka.ID_Narudzba=@narudzba", con);
            cmd.Parameters.AddWithValue("@narudzba", narudzba);
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter(cmd);
            adapt.Fill(dt);
            dataGridViewIsp.DataSource = dt;
            con.Close();
        }


        private void DisplayDataProizvodi()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("Select * from Proizvod", con);
            adapt.Fill(dt);
            dataGridViewPr.DataSource = dt;
            con.Close();
        }

        private bool ProvjeraUnosaKol(string kolicina)
        {
            try
            {
                int kol = int.Parse(kolicina);
                if(kol <= 0)
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            
            if (kolicina.Length == 0)
            {
                return false;
            }

            return true;
        }

        private bool ProvjeraUnosaID(string unos)
        {
            try
            {
                int id_unos = int.Parse(unos);
            }
            catch
            {
                return false;
            }
            return true;
        }

        private string DohvatiIdSektora(string oznaka)
        {
            string id = "";
            cmd = new SqlCommand("Select * from SektorSkladista where OznakaSektora=@oznaka", con);
            cmd.Parameters.AddWithValue("@oznaka", oznaka);
            con.Open();
            adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            adapt.Fill(dt);
            adapt.Fill(ds);
            con.Close();
            int count = ds.Tables[0].Rows.Count;
            if (count == 1)
            {
                id = dt.Rows[0]["ID_Sektor"].ToString();
            }
            return id;
        }

        private void btnDodajIsp_Click(object sender, EventArgs e)
        {
            PopunjavanjeProzora();
            btnSpremiIsp.Show();
            btnPromijeniIsp.Hide();

            IsprazniBox();
        }

        private void btnOdaberiPr_Click(object sender, EventArgs e)
        {
            dataGridViewPr.Show();
        }

        private void btnSpremiIsp_Click(object sender, EventArgs e)
        {
            string kolicina = txtKolicinaPr.Text;
            DateTime datum = dateTimePicker1.Value;
            string id_pr = txtIdProizvod.Text;
            string id_nar = txtIdNarudzba.Text;
            string id_sekt = DohvatiIdSektora(txtSektor.Text);

            if (datum != null && ProvjeraUnosaKol(kolicina) && ProvjeraUnosaID(id_pr) && ProvjeraUnosaID(id_nar) && ProvjeraUnosaID(id_sekt))
            {
                cmd = new SqlCommand("insert into Isporuka(Kolicina, Datum, ID_Proizvod, ID_Narudzba, ID_Sektor)" +
                    " values(@kolicina, @datum, @id_pr, @id_nar, @id_sekt)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@kolicina", kolicina);
                cmd.Parameters.AddWithValue("@datum", datum);
                cmd.Parameters.AddWithValue("@id_pr", id_pr);
                cmd.Parameters.AddWithValue("@id_nar", id_nar);
                cmd.Parameters.AddWithValue("@id_sekt", id_sekt);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Uspješno ste unijeli novu isporuku!");
                DisplayDataIsporuke(ID_Narudzba);
                CiscenjeProzora();
                IsprazniBox();
            }
            else
            {
                MessageBox.Show("Niste popunili ispravno sva polja. Pokušajte ponovno!");
            }

        }

        private void dataGridViewPr_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtIdProizvod.Text = dataGridViewPr.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btnZakljuciNar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

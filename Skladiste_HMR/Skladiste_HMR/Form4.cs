using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace Skladiste_HMR
{
    public partial class Form4 : Form
    {
        string ulogaGlob = "";
        SqlConnection con = new SqlConnection(Konstante.ConnectionString);
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int ID = -1;
        string defDatum = "";

        string ID_Narudzba = "";

        public Form4(string uloga)
        {
            ulogaGlob = uloga;
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            CiscenjeProzora();
            btnBrisiNar.Hide();

            if (ulogaGlob == "radnik")
            {
                btnDodajNar.Hide();
            }
            try
            {
                DisplayDataNarudzbe();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDodajNar_Click(object sender, EventArgs e)
        {
            PopunjavanjeProzora();
            IsprazniBox();
        }

        private void CiscenjeProzora()
        {
            ID = -1;
            lblDatum.Hide();
            datumNar.Hide();
            btnSpremiDodaj.Hide();
            dataGridViewIsp.Hide();
        }

        private void PopunjavanjeProzora()
        {
            lblDatum.Show();
            datumNar.Show();
            btnSpremiDodaj.Show();
        }

        private void IsprazniBox()
        {
            datumNar.Value = DateTime.Now;
        }
        private void DisplayDataNarudzbe()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("Select * from Narudzba", con);
            adapt.Fill(dt);
            dataGridViewNar.DataSource = dt;
            con.Close();

            int zadnjiRed = dt.Rows.Count - 1;

            ID_Narudzba = dt.Rows[zadnjiRed]["ID_Narudzba"].ToString();
        }

        private void DisplayData_Isporuke(string id_nar)
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

        private void btnSpremiDodaj_Click(object sender, EventArgs e)
        {
            DateTime datum = datumNar.Value;

            if (datum != null)
            {
                cmd = new SqlCommand("insert into Narudzba(Datum)" +
                    " values(@datum)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@datum", datum);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Uspješno ste unijeli novu narudžbu!");
                DisplayDataNarudzbe();
                CiscenjeProzora();
              
                Form7 fm7 = new Form7(ID_Narudzba);
                fm7.Show();
            }

        }

        private void dataGridViewNar_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (ulogaGlob == "poslovoda")
            {
                btnBrisiNar.Show();
                CiscenjeProzora();
                IsprazniBox();

                ID = Convert.ToInt32(dataGridViewNar.Rows[e.RowIndex].Cells[0].Value.ToString());
                defDatum = dataGridViewNar.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            dataGridViewIsp.Show();
            DisplayData_Isporuke(ID.ToString());
        }
       
        private void btnBrisiNar_Click(object sender, EventArgs e)
        {
            if (ID != -1)
            {
                BrisanjeNarudzbe(ID);
                MessageBox.Show("Uspješno izbrisana narudžba!");
                DisplayDataNarudzbe();
                CiscenjeProzora();
                IsprazniBox();
            }
            else
            {
                MessageBox.Show("Odaberite narudžbu za brisanje!");
            }
        }

        private bool ProvjeraNarudzbe(int id)
        {
            cmd = new SqlCommand("Select * from Isporuka where ID_Narudzba=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            con.Close();
            int count = ds.Tables[0].Rows.Count;
            if (count > 0)
            {
                return false;
            }
            return true;
        }

        private void BrisanjeNarudzbe(int id)
        {
            if (!ProvjeraNarudzbe(id))
            {
                SqlCommand cmdPomocna = new SqlCommand("delete Isporuka where ID_Narudzba=@id", con);
                con.Open();
                cmdPomocna.Parameters.AddWithValue("@id", id);
                cmdPomocna.ExecuteNonQuery();
                con.Close();
            }
            cmd = new SqlCommand("delete Narudzba where ID_Narudzba=@id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void dataGridViewNar_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Form7 fm7 = new Form7(ID.ToString());
            fm7.Show();
        }
    }
    
}

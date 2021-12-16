using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Skladiste_HMR
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            btnBrisiPr.Hide();
            btnUrediPr.Hide();
            btnSpremiPr.Hide();
            btnPromijeniPr.Hide();
            txtNazivPr.Hide();
            txtCijenaPr.Hide();
            lblNazivPr.Hide();
            lblCijenaPr.Hide();
            try
            {
                SqlConnection con = new SqlConnection(Konstante.ConnectionString);
                SqlCommand cmd = new SqlCommand("Select * from Proizvod", con);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                //close connection
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnBrisiPr.Show();
            btnUrediPr.Show();
            btnSpremiPr.Hide();
            btnPromijeniPr.Hide();
            txtNazivPr.Hide();
            txtCijenaPr.Hide();
            lblNazivPr.Hide();
            lblCijenaPr.Hide();
        }

        private void btnBrisiPr_Click(object sender, EventArgs e)
        {

        }

        private void btnDodajPr_Click(object sender, EventArgs e)
        {
            btnSpremiPr.Show();
            btnPromijeniPr.Hide();
            txtNazivPr.Show();
            txtCijenaPr.Show();
            lblNazivPr.Show();
            lblCijenaPr.Show();
            txtNazivPr.Text = "";
            txtCijenaPr.Text = "";
        }

        private void btnUrediPr_Click(object sender, EventArgs e)
        {
            btnPromijeniPr.Hide();
            btnSpremiPr.Show();
            txtNazivPr.Show();
            txtCijenaPr.Show();
            lblNazivPr.Show();
            lblCijenaPr.Show();
            txtNazivPr.Text = "";
            txtCijenaPr.Text = "";
        }

        private void btnPromijeniPr_Click(object sender, EventArgs e)
        {

        }

        private void btnSpremiPr_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Skladiste_HMR
{
    public partial class Form6 : Form
    {
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

            txtIme.Text = "";
            txtPrezime.Text = "";
            txtKorIme.Text = "";
            txtLozinka.Text = "";
            cmbBoxUloga.Text = "";
        }

        private void btnSpremiKor_Click(object sender, EventArgs e)
        {

        }

        private void btnPromijeniKor_Click(object sender, EventArgs e)
        {

        }

        private void btnBrisiKor_Click(object sender, EventArgs e)
        {

        }
    }
}

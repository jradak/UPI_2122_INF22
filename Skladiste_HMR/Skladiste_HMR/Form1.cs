using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Skladiste_HMR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //string na bazu podataka
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Skladiste;Integrated Security=True;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private void label1_Click(object sender, EventArgs e)
        {

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
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("Select * from Korisnik where KorisnickoIme=@kIme and Lozinka=@lozinka", con);
                cmd.Parameters.AddWithValue("@kIme", kIme);
                cmd.Parameters.AddWithValue("@lozinka", lozinka);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    MessageBox.Show("Usješno ste se prijavili!");
                    this.Hide();
                    Form2 fm2 = new Form2();
                    fm2.Show();
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
    }
}

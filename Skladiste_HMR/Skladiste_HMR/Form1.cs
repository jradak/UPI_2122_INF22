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
using System.Data.Common;

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
            string uloga = "";
            if (kIme == "" || lozinka == "") 
            {
                MessageBox.Show("Niste popunili sva polja! Pokušajte ponovno!");
                return;
            }
            try
            {
                //string queryPorslijedivanje = "Select KorisnickoIme, Uloga from Korisnik where korisnickoIme=@kIme and Lozinka=@lozinka";

                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("Select * from Korisnik where KorisnickoIme=@kIme and Lozinka=@lozinka", con);
                cmd.Parameters.AddWithValue("@kIme", kIme);
                cmd.Parameters.AddWithValue("@lozinka", lozinka);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                adapt.Fill(ds);
                adapt.Fill(dt);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    MessageBox.Show("Usješno ste se prijavili!");
                    uloga = dt.Rows[0]["Uloga"].ToString();
                    this.Hide();
                    
                    Form2 fm2 = new Form2(kIme, uloga);
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

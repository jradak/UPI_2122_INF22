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
    public partial class frmPrijava : Form
    {
        public frmPrijava()
        {
            InitializeComponent();
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
                //string queryPorslijedivanje = "Select KorisnickoIme, Uloga from Korisnik where korisnickoIme=@kIme and Lozinka=@lozinka";

                SqlConnection con = new SqlConnection(Konstante.ConnectionString);
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
                    int id = int.Parse(dt.Rows[0]["ID_Korisnik"].ToString());
                    string ime = dt.Rows[0]["Ime"].ToString();
                    string pr = dt.Rows[0]["Prezime"].ToString();
                    string korIme = dt.Rows[0]["KorisnickoIme"].ToString();
                    string loz = dt.Rows[0]["Lozinka"].ToString();
                    string uloga = dt.Rows[0]["Uloga"].ToString();

                    Korisnik k = new Korisnik(id, ime, pr, korIme, loz, uloga);
                    MessageBox.Show("Usješno ste se prijavili!");
                    this.Hide();
                    frmPocetna pocetna = new frmPocetna(ime, uloga );
                    pocetna.Show();
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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Skladiste_HMR
{
    public class Korisnik
    {
        private int id;
        private string ime;
        private string prezime;
        private string korisnickoIme;
        private string lozinka;
        private string uloga;

        public int Id { get => id; set => id = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        public string Lozinka { get => lozinka; set => lozinka = value; }
        public string Uloga { get => uloga; set => uloga = value; }

        public Korisnik(int id, string i, string p, string ki, string l, string u)
        {
            this.Id = id;
            this.Ime = i;
            this.Prezime = p;
            this.KorisnickoIme = ki;
            this.Lozinka = l;
            this.Uloga = u;
        }

        public void PrikazKorisnika(DataGridView grid)
        {
            SqlConnection con = new SqlConnection(Konstante.ConnectionString);
            SqlDataAdapter adapt;
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Korisnik", con);
            adapt.Fill(dt);
            grid.DataSource = dt;
            con.Close();
        }
        public void DodavanjeKorisnika(string ime, string prezime, string korisnickoIme,
            string lozinka, string uloga)
        {
            SqlConnection con = new SqlConnection(Konstante.ConnectionString);
            SqlCommand cmd;
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
        }
        public void UredivanjeKorisnika(int id, string ime, string prezime,
            string korisnickoIme, string lozinka, string uloga)
        {
            SqlConnection con = new SqlConnection(Konstante.ConnectionString);
            SqlCommand cmd;
            cmd = new SqlCommand("update Korisnik set Ime=@ime,Prezime=@prezime, KorisnickoIme=@kIme, " +
                    "Lozinka=@lozinka,Uloga=@uloga where ID_Korisnik=@id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@ime", ime);
            cmd.Parameters.AddWithValue("@prezime", prezime);
            cmd.Parameters.AddWithValue("@kIme", korisnickoIme);
            cmd.Parameters.AddWithValue("@lozinka", lozinka);
            cmd.Parameters.AddWithValue("@uloga", uloga);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void BrisanjeKorisnika(int id)
        {
            SqlConnection con = new SqlConnection(Konstante.ConnectionString);
            SqlCommand cmd;
            cmd = new SqlCommand("delete Korisnik where ID_Korisnik=@id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public bool PostojanostKorisnika(string kIme, string lozinka)
        {
            SqlConnection con = new SqlConnection(Konstante.ConnectionString);
            SqlCommand cmd;
            SqlDataAdapter adapt;
            cmd = new SqlCommand("Select * from Korisnik where KorisnickoIme=@kIme and Lozinka=@lozinka", con);
            cmd.Parameters.AddWithValue("@kIme", kIme);
            cmd.Parameters.AddWithValue("@lozinka", lozinka);
            con.Open();
            adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            con.Close();
            int count = ds.Tables[0].Rows.Count;
            //ako postoji jedinstveni
            if (count == 1)
            {
                return true;
            }
            return false;
        }
        public string[] DohvatiPodatkeZaPrijavu(string kIme, string lozinka)
        {
            SqlConnection con = new SqlConnection(Konstante.ConnectionString);
            SqlCommand cmd;
            SqlDataAdapter adapt;
            cmd = new SqlCommand("Select * from Korisnik where KorisnickoIme=@kIme and Lozinka=@lozinka", con);
            cmd.Parameters.AddWithValue("@kIme", kIme);
            cmd.Parameters.AddWithValue("@lozinka", lozinka);
            con.Open();
            adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            con.Close();
            string id = dt.Rows[0]["ID_Korisnik"].ToString();
            string ime = dt.Rows[0]["Ime"].ToString();
            string pr = dt.Rows[0]["Prezime"].ToString();
            string korIme = dt.Rows[0]["KorisnickoIme"].ToString();
            string loz = dt.Rows[0]["Lozinka"].ToString();
            string uloga = dt.Rows[0]["Uloga"].ToString();
            string[] niz = { id, ime, pr, korIme, loz, uloga };
            return niz;
        }
    }
}

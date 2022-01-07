using System.Data;
using System.Data.SqlClient;

namespace Skladiste_HMR
{
    class SektorSkladista
    {
        private int id;
        private string oznakaSektora;

        public int Id { get => id; set => id = value; }
        public string OznakaSektora { get => oznakaSektora; set => oznakaSektora = value; }

        public SektorSkladista(int id, string naziv)
        {
            this.Id = id;
            this.OznakaSektora = naziv;
        }

        public string DohvatiNazivSektora(string oznaka)
        {
            SqlConnection con = new SqlConnection(Konstante.ConnectionString);
            SqlCommand cmd;
            SqlDataAdapter adapt;
            string naziv = "";
            cmd = new SqlCommand("Select * from SektorSkladista where ID_Sektor=@oznaka", con);
            cmd.Parameters.AddWithValue("@oznaka", oznaka);
            con.Open();
            adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            adapt.Fill(dt);
            adapt.Fill(ds);
            con.Close();
            int count = ds.Tables[0].Rows.Count;
            //ako postoji jedinstveni
            if (count == 1)
            {
                naziv = dt.Rows[0]["OznakaSektora"].ToString();
            }
            return naziv;
        }
        public string DohvatiIdSektora(string oznaka)
        {
            SqlConnection con = new SqlConnection(Konstante.ConnectionString);
            SqlCommand cmd;
            SqlDataAdapter adapt;
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
            //ako postoji jedinstveni
            if (count == 1)
            {
                id = dt.Rows[0]["ID_Sektor"].ToString();
            }
            return id;
        }
    }
}

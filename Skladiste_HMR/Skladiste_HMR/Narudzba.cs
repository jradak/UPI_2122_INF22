using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Skladiste_HMR
{
    class Narudzba
    {
        private int id;
        DateTime datum;

        public int Id { get => id; set => id = value; }
        public DateTime Datum { get => datum; set => datum = value; }

        public Narudzba(int id, DateTime datum)
        {
            this.Id = id;
            this.Datum = datum;
        }
        public void PrikazNarudzbi(DataGridView grid)
        {
            SqlDataAdapter adapt;
            SqlConnection con = new SqlConnection(Konstante.ConnectionString);
            SqlCommand cmd;
            cmd = new SqlCommand("Select * from Narudzba ", con);
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter(cmd);
            adapt.Fill(dt);
            grid.DataSource = dt;
            con.Close();
        }
        public void DodavanjeNarudzbi(DateTime datum)
        {
            SqlConnection con = new SqlConnection(Konstante.ConnectionString);
            SqlCommand cmd;
            cmd = new SqlCommand("insert into Narudzba(Datum)" +
                   " values(@datum)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@datum", datum);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void UredivanjeNarudzbe(int id, DateTime datum)
        {
            SqlConnection con = new SqlConnection(Konstante.ConnectionString);
            SqlCommand cmd;
            cmd = new SqlCommand("update Narudzba(Datum) set Datum=@datum where ID_Narudzba=@id" +
                   " values(@datum)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@datum", datum);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void BrisanjeNarudzbe(int id)
        {
            SqlConnection con = new SqlConnection(Konstante.ConnectionString);
            SqlCommand cmd;
            SqlCommand cmdPomocna;
            if (!ProvjeraNarudzbe(id))
            {
                cmdPomocna = new SqlCommand("delete Isporuka where ID_Narudzba=@id", con);
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
        private bool ProvjeraNarudzbe(int id)
        {
            SqlConnection con = new SqlConnection(Konstante.ConnectionString);
            SqlCommand cmd;
            SqlDataAdapter adapt;
            cmd = new SqlCommand("Select * from Isporuka where ID_Narudzba=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            con.Close();
            int count = ds.Tables[0].Rows.Count;
            // ako postoji isporuka koja ovisi o id neke narudzbe
            if (count > 0)
            {
                return false;
            }
            return true;
        }
    }
}

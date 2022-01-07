using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Skladiste_HMR
{
    class Proizvod
    {
        private int id;
        private string naziv;
        private string cijena;


        public int Id { get => id; set => id = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public string Cijena { get => cijena; set => cijena = value; }


        public Proizvod(string naziv, string cijena, int id)
        {
            this.Id = id;
            this.Naziv = naziv;
            this.Cijena = cijena;
        }

        public void PrikazProizvoda(DataGridView grid)
        {
            SqlConnection con = new SqlConnection(Konstante.ConnectionString);
            SqlDataAdapter adapt;
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("Select * from Proizvod", con);
            adapt.Fill(dt);
            grid.DataSource = dt;
            con.Close();
        }

        public void DodavanjeProizvoda(string naziv, string cijena)
        {
            SqlConnection con = new SqlConnection(Konstante.ConnectionString);
            SqlCommand cmd;
            cmd = new SqlCommand("insert into Proizvod(Naziv, Cijena)" +
                   " values(@naziv, @cijena)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@naziv", naziv);
            cmd.Parameters.AddWithValue("@cijena", cijena);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void UredivanjeProizvoda(int id, string naziv, string cijena)
        {
            SqlConnection con = new SqlConnection(Konstante.ConnectionString);
            SqlCommand cmd;
            cmd = new SqlCommand("update Proizvod set Naziv=@naziv, Cijena=@cijena" +
                    " where ID_Proizvod=@id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@naziv", naziv);
            cmd.Parameters.AddWithValue("@cijena", cijena);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void BrisanjeProizvoda(int id)
        {
            SqlConnection con = new SqlConnection(Konstante.ConnectionString);
            SqlCommand cmd;
            SqlCommand cmdPomocna;
            if (!ProvjeraProizvoda(id))
            {
                cmdPomocna = new SqlCommand("delete Isporuka where ID_Proizvod=@id", con);
                con.Open();
                cmdPomocna.Parameters.AddWithValue("@id", id);
                cmdPomocna.ExecuteNonQuery();
                con.Close();
            }
            cmd = new SqlCommand("delete Proizvod where ID_Proizvod=@id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private bool ProvjeraProizvoda(int id)
        {
            SqlConnection con = new SqlConnection(Konstante.ConnectionString);
            SqlCommand cmd;
            SqlDataAdapter adapt;
            cmd = new SqlCommand("Select * from Isporuka where ID_Proizvod=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            con.Close();
            int count = ds.Tables[0].Rows.Count;
            //ako ima isporuka koje sadrzavaju id proizvoda
            if (count > 0)
            {
                return false;
            }
            return true;
        }

        public int DohvatiIdProizvoda(string naziv)
        {
            SqlConnection con = new SqlConnection(Konstante.ConnectionString);
            SqlCommand cmd;
            SqlDataAdapter adapt;
            string id = "";
            cmd = new SqlCommand("Select * from Proizvod where Naziv=@naziv", con);
            cmd.Parameters.AddWithValue("@naziv", naziv);
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
                id = dt.Rows[0]["ID_Proizvod"].ToString();
            }

            int id_ = int.Parse(id);

            return id_;
        }
    }
}

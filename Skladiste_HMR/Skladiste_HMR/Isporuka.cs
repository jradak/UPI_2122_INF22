using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Skladiste_HMR
{
    class Isporuka
    {
        private int id;
        private int kolicina;
        private DateTime datum;
        private int idProizvod;
        private int idNarudzba;
        private int idSektor;

        public int Id { get => id; set => id = value; }
        public int Kolicina { get => kolicina; set => kolicina = value; }
        public DateTime Datum { get => datum; set => datum = value; }
        public int IdProizvod { get => idProizvod; set => idProizvod = value; }
        public int IdNarudzba { get => idNarudzba; set => idNarudzba = value; }
        public int IdSektor { get => idSektor; set => idSektor = value; }

        public Isporuka(int id, int kolicina, DateTime datum, int proizvod, int narudzba, int sektor)
        {
            this.Id = id;
            this.Kolicina = kolicina;
            this.Datum = datum;
            this.IdProizvod = proizvod;
            this.IdNarudzba = narudzba;
            this.IdSektor = sektor;
        }

        public void PrikazIsporukaSektora(string id_sektor, DataGridView grid)
        {
            SqlDataAdapter adapt;
            SqlConnection con = new SqlConnection(Konstante.ConnectionString);
            SqlCommand cmd;
            int sektor = int.Parse(id_sektor);
            cmd = new SqlCommand("Select Isporuka.ID_Isporuka, Isporuka.Kolicina, Isporuka.Datum, " +
                "Proizvod.Naziv, Proizvod.Cijena, Isporuka.ID_Sektor from Isporuka inner join Proizvod " +
                "on Isporuka.ID_Proizvod=Proizvod.ID_Proizvod where Isporuka.ID_Sektor=@sektor and Isporuka.Kolicina > 0", con);
            cmd.Parameters.AddWithValue("@sektor", sektor);
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter(cmd);
            adapt.Fill(dt);
            grid.DataSource = dt;
            con.Close();
        }
        public void PrikazIsporukaNarudzbe(int idNarudzba, DataGridView grid)
        {
            SqlDataAdapter adapt;
            SqlConnection con = new SqlConnection(Konstante.ConnectionString);
            SqlCommand cmd;
            cmd = new SqlCommand("Select Isporuka.ID_Isporuka, Isporuka.Kolicina, Isporuka.Datum, " +
            "Proizvod.Naziv, Proizvod.Cijena, Isporuka.ID_Narudzba from Isporuka inner join Proizvod " +
            "on Isporuka.ID_Proizvod=Proizvod.ID_Proizvod where Isporuka.ID_Narudzba=@id ", con);
            cmd.Parameters.AddWithValue("@id", idNarudzba);
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter(cmd);
            adapt.Fill(dt);
            grid.DataSource = dt;
            con.Close();

        }
        public void PrikazPraznihIsporuka(DataGridView grid)
        {
            SqlDataAdapter adapt;
            SqlConnection con = new SqlConnection(Konstante.ConnectionString);
            SqlCommand cmd;
            cmd = new SqlCommand("Select Isporuka.ID_Isporuka, Isporuka.Kolicina, Isporuka.Datum, " +
                "Proizvod.Naziv, Proizvod.Cijena, Isporuka.ID_Sektor from Isporuka inner join Proizvod " +
                "on Isporuka.ID_Proizvod=Proizvod.ID_Proizvod where Isporuka.Kolicina = 0", con);
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter(cmd);
            adapt.Fill(dt);
            grid.DataSource = dt;
            con.Close();
        }
        public void DodavanjeIsporuke(DateTime datum, int kolicina, int proizvod, int narudzba, int _idSektor)
        {
            SqlConnection con = new SqlConnection(Konstante.ConnectionString);
            SqlCommand cmd;
            cmd = new SqlCommand("insert into Isporuka(Kolicina, Datum, ID_Proizvod, ID_Narudzba,ID_Sektor) " +
                "values(@kolicina, @datum, @proizvod, @narudzba, @sektor)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@kolicina", kolicina);
            cmd.Parameters.AddWithValue("@datum", datum);
            cmd.Parameters.AddWithValue("@proizvod", proizvod);
            cmd.Parameters.AddWithValue("@narudzba", narudzba);
            cmd.Parameters.AddWithValue("@sektor", _idSektor);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void UredivanjeIsporukeNarudzbe(int id, DateTime datum, int kolicina,int _idProizvod)
        {
            SqlConnection con = new SqlConnection(Konstante.ConnectionString);
            SqlCommand cmd;
            cmd = new SqlCommand("update Isporuka set Kolicina=@kolicina, Datum=@datum, ID_Proizvod=@proizvod" +
                    " where ID_Isporuka=@id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@datum", datum);
            cmd.Parameters.AddWithValue("@kolicina", kolicina);
            cmd.Parameters.AddWithValue("@proizvod", _idProizvod);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void UredivanjeIsporukeSektora(int id, DateTime datum, int kolicina, int _idSektor)
        {
            SqlConnection con = new SqlConnection(Konstante.ConnectionString);
            SqlCommand cmd;
            cmd = new SqlCommand("update Isporuka set Kolicina=@kolicina, Datum=@datum, ID_Sektor=@sektor" +
                    " where ID_Isporuka=@id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@datum", datum);
            cmd.Parameters.AddWithValue("@kolicina", kolicina);
            cmd.Parameters.AddWithValue("@sektor", _idSektor);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void BrisanjeIsporuke(int id)
        {
            SqlConnection con = new SqlConnection(Konstante.ConnectionString);
            SqlCommand cmd;
            cmd = new SqlCommand("delete Isporuka where ID_Isporuka=@id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}

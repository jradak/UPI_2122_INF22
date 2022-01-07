using System;
using System.Windows.Forms;

namespace Skladiste_HMR
{
    public partial class frmIsporuke : Form
    {
        int narudzba = -1;
        Isporuka isporuka = new Isporuka(-1, -1, DateTime.Today, -1, -1, -1);
        Proizvod proizvod = new Proizvod(null, null, -1);
        SektorSkladista sektor = new SektorSkladista(-1, null);
        
        public frmIsporuke(int id_narudzba)
        {
            narudzba = id_narudzba;
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            txtBoxNarudzba.Text = narudzba.ToString();
            CiscenjeProzora();
            btnBrisiIsp.Hide();
            btnUrediIsp.Hide();

            try
            {
                isporuka.PrikazIsporukaNarudzbe(narudzba, dataGridViewIsp);
                proizvod.PrikazProizvoda(dataGridViewPr);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDodajIsp_Click(object sender, EventArgs e)
        {
            PopunjavanjeProzora();
            btnSpremiIsp.Show();
            btnPromijeniIsp.Hide();

            IsprazniBox();
        }

        private void btnOdaberiPr_Click(object sender, EventArgs e)
        {
            dataGridViewPr.Show();
        }

        private void btnSpremiIsp_Click(object sender, EventArgs e)
        {
            int kolicina = int.Parse(numericKol.Value.ToString());
            DateTime datum = dateTimePicker1.Value;
            string proizvod = txtBoxProizvod.Text;
            isporuka.IdNarudzba = int.Parse(txtBoxNarudzba.Text);
            sektor.OznakaSektora = txtBoxSektor.Text;
            isporuka.IdSektor = int.Parse(sektor.DohvatiIdSektora(sektor.OznakaSektora));
            
            if (kolicina > 0 && proizvod!="")
            {
                isporuka.IdProizvod = int.Parse(proizvod);
                isporuka.DodavanjeIsporuke(datum, kolicina, 
                    isporuka.IdProizvod, isporuka.IdNarudzba, isporuka.IdSektor);
                MessageBox.Show("Uspješno ste unijeli novu isporuku!");
                isporuka.PrikazIsporukaNarudzbe(narudzba, dataGridViewIsp);
                CiscenjeProzora();
                IsprazniBox();
            }
            else
            {
                MessageBox.Show("Niste popunili ispravno sva polja. Pokušajte ponovno!");
            }

        }

        private void dataGridViewPr_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtBoxProizvod.Text = dataGridViewPr.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btnZakljuciNar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CiscenjeProzora()
        {
            isporuka.Id = -1;
            btnSpremiIsp.Hide();
            btnPromijeniIsp.Hide();
            btnOdaberiPr.Hide();
            lblIdNarudzba.Hide();
            txtBoxNarudzba.Hide();
            lblDatum.Hide();
            lblKolicinaPr.Hide();
            lblSektor.Hide();
            lblProizvod.Hide();
            lblIdProizvod.Hide();
            txtBoxSektor.Hide();
            txtBoxProizvod.Hide();
            dateTimePicker1.Hide();
            numericKol.Hide();
            dataGridViewPr.Hide();
            btnZakljuciNar.Show();
        }
        private void PopunjavanjeProzora()
        {
            btnOdaberiPr.Show();
            lblIdNarudzba.Show();
            txtBoxNarudzba.Show();
            lblDatum.Show();
            lblKolicinaPr.Show();
            lblSektor.Show();
            lblProizvod.Show();
            lblIdProizvod.Show();
            txtBoxSektor.Show();
            txtBoxProizvod.Show();
            dateTimePicker1.Show();
            numericKol.Show();
        }

        private void IsprazniBox()
        {
            dateTimePicker1.Value = DateTime.Today;
            numericKol.Value = 0;
            txtBoxProizvod.Text = "";
        }

        private void btnBrisiIsp_Click(object sender, EventArgs e)
        {
            if (isporuka.Id != -1)
            {
                isporuka.BrisanjeIsporuke(isporuka.Id);
                MessageBox.Show("Uspješno izbrisana isporuka!");
                isporuka.PrikazIsporukaNarudzbe(narudzba, dataGridViewIsp);
                CiscenjeProzora();
                dataGridViewIsp.ClearSelection();
                btnBrisiIsp.Hide();
                btnUrediIsp.Hide();

            }
            else
            {
                MessageBox.Show("Odaberite isporuku za brisanje!");
            }
        }

        private void btnUrediIsp_Click(object sender, EventArgs e)
        {
            PopunjavanjeProzora();
            btnPromijeniIsp.Show();
            btnSpremiIsp.Hide();

            numericKol.Value = isporuka.Kolicina;
            dateTimePicker1.Value = isporuka.Datum;
            txtBoxProizvod.Text = isporuka.IdProizvod.ToString();
                  
        }

        private void dataGridViewIsp_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnBrisiIsp.Show();
            btnUrediIsp.Show();
            CiscenjeProzora();
            IsprazniBox();
            isporuka.Id = Convert.ToInt32(dataGridViewIsp.Rows[e.RowIndex].Cells[0].Value.ToString());
            isporuka.Kolicina = int.Parse(dataGridViewIsp.Rows[e.RowIndex].Cells[1].Value.ToString());
            isporuka.Datum = DateTime.Parse(dataGridViewIsp.Rows[e.RowIndex].Cells[2].Value.ToString());
            isporuka.IdProizvod = proizvod.DohvatiIdProizvoda(dataGridViewIsp.Rows[e.RowIndex].Cells[3].Value.ToString());

        }

        private void btnPromijeniIsp_Click(object sender, EventArgs e)
        {
            int kolicina = int.Parse(numericKol.Value.ToString());
            DateTime datum = dateTimePicker1.Value;
            string proizvod = txtBoxProizvod.Text;
  
            if (kolicina > 0 && proizvod != "")
            {
                isporuka.IdProizvod = int.Parse(proizvod);
                isporuka.UredivanjeIsporukeNarudzbe(isporuka.Id, datum, kolicina,
                    isporuka.IdProizvod);
                MessageBox.Show("Uspješno ste promijenili podatke o isporuci!");
                isporuka.PrikazIsporukaNarudzbe(narudzba, dataGridViewIsp);
                CiscenjeProzora();
                IsprazniBox();
                dataGridViewIsp.ClearSelection();
                btnBrisiIsp.Hide();
                btnUrediIsp.Hide();
            }
            else
            {
                MessageBox.Show("Niste popunili ispravno sva polja. Pokušajte ponovno!");
            }
        }
    }
}

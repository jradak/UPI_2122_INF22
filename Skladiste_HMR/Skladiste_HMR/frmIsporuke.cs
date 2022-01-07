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
            isporuka.Kolicina = int.Parse(numericKol.Value.ToString());
            isporuka.Datum = dateTimePicker1.Value;
            string proizvod = txtBoxProizvod.Text;
            isporuka.IdNarudzba = int.Parse(txtBoxNarudzba.Text);
            sektor.OznakaSektora = txtBoxSektor.Text;
            isporuka.IdSektor = int.Parse(sektor.DohvatiIdSektora(sektor.OznakaSektora));
            
            if (isporuka.Kolicina > 0 && proizvod!="")
            {
                isporuka.IdProizvod = int.Parse(proizvod);
                isporuka.DodavanjeIsporuke(isporuka.Datum, isporuka.Kolicina, 
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
            btnZakljuciNar.Hide();
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
            btnZakljuciNar.Show();
        }

        private void IsprazniBox()
        {
            dateTimePicker1.Value = DateTime.Today;
            numericKol.Text = "";
            txtBoxProizvod.Text = "";
        }
    }
}

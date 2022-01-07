using System;
using System.Drawing;
using System.Windows.Forms;

namespace Skladiste_HMR
{
    public partial class frmSkladiste : Form
    {
        SektorSkladista sektor = new SektorSkladista(-1, null);
        Isporuka isporuka = new Isporuka(-1, -1, DateTime.Today, -1, -1, -1);
        Korisnik korisnik;
        string def_sektor = "";

        public frmSkladiste(Korisnik k)
        {
            korisnik = k;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            CiscenjeProzora();
            IsprazniBox();
        }
        private void btnSektorA_Click(object sender, EventArgs e)
        {
            sektor.OznakaSektora = sektor.DohvatiIdSektora(btnSektorA.Text);
            isporuka.PrikazIsporukaSektora(sektor.OznakaSektora, dataGridView1);
        }

        private void btnSektorB_Click(object sender, EventArgs e)
        {
            sektor.OznakaSektora = sektor.DohvatiIdSektora(btnSektorB.Text);
            isporuka.PrikazIsporukaSektora(sektor.OznakaSektora, dataGridView1);
        }

        private void btnSektorC_Click(object sender, EventArgs e)
        {
            sektor.OznakaSektora = sektor.DohvatiIdSektora(btnSektorC.Text);
            isporuka.PrikazIsporukaSektora(sektor.OznakaSektora, dataGridView1);
        }

        private void btnSektorD_Click(object sender, EventArgs e)
        {
            sektor.OznakaSektora = sektor.DohvatiIdSektora(btnSektorD.Text);
            isporuka.PrikazIsporukaSektora(sektor.OznakaSektora, dataGridView1);
        }

        private void btnSektorE_Click(object sender, EventArgs e)
        {
            sektor.OznakaSektora = sektor.DohvatiIdSektora(btnSektorE.Text);
            isporuka.PrikazIsporukaSektora(sektor.OznakaSektora, dataGridView1);
        }

        private void btnNedefinirani_Click(object sender, EventArgs e)
        {
            sektor.Id = int.Parse(sektor.DohvatiIdSektora(btnNedefinirani.Text));
            isporuka.PrikazIsporukaSektora(sektor.Id.ToString(), dataGridView1);
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnUredi.Show();
            isporuka.Id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            isporuka.Kolicina = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            def_sektor = sektor.DohvatiNazivSektora(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
            isporuka.IdSektor = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
            isporuka.Datum = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());

            numericKolicina.Value = isporuka.Kolicina;
            dateTimePicker1.Value = isporuka.Datum;
            cmbBoxSektor.Text = def_sektor;
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            PopunjavanjeProzora();
            if (korisnik.Uloga == "radnik")
            {
                dateTimePicker1.Hide();
                cmbBoxSektor.Hide();
                lblDatum.Hide();
                lblSektor.Hide();
                btnUrediSkladiste.Hide();
                btnPrimjeni.Location = new Point(552, 350);
            }
            else
            {
                btnPrimjeni.Location = new Point(552, 438);
            }

        }

        private void btnPrimjeni_Click(object sender, EventArgs e)
        {
            int kolicina = int.Parse(numericKolicina.Value.ToString());
            DateTime datum = dateTimePicker1.Value;
            int id_sektor = int.Parse(sektor.DohvatiIdSektora(cmbBoxSektor.Text));

            if (kolicina > -1 && id_sektor > -1)
            {
                isporuka.UredivanjeIsporukeSektora(isporuka.Id, datum, kolicina, id_sektor);
                MessageBox.Show("Uspješno ste promijenili podatke o proizvodu!");
                isporuka.PrikazIsporukaSektora(sektor.DohvatiIdSektora(cmbBoxSektor.Text), dataGridView1);
                CiscenjeProzora();
                IsprazniBox();
            }
            else
            {
                MessageBox.Show("Niste popunili ispravno sva polja. Pokušajte ponovno!");
            }

        }

        private void btnGotoveIsporuke_Click(object sender, EventArgs e)
        {
            CiscenjeProzora();
            isporuka.PrikazPraznihIsporuka(dataGridView1);
        }
        
        private void btnUrediSkladiste_Click(object sender, EventArgs e)
        {
            //nefunkcionalno
            //uredivanje izgleda skladista
        }
        
        private void PopunjavanjeProzora()
        {
            btnPrimjeni.Show();
            lblSektor.Show();
            lblKolicina.Show();
            lblDatum.Show();
            numericKolicina.Show();
            dateTimePicker1.Show();
            cmbBoxSektor.Show();
        }
        private void CiscenjeProzora()
        {
            btnUredi.Hide();
            btnPrimjeni.Hide();
            lblSektor.Hide();
            lblKolicina.Hide();
            lblDatum.Hide();
            numericKolicina.Hide();
            dateTimePicker1.Hide();
            cmbBoxSektor.Hide();
        }
        private void IsprazniBox()
        {
            numericKolicina.Value = 0;
            dateTimePicker1.Value = DateTime.Now;
            cmbBoxSektor.Text = "";
        }
    }
}

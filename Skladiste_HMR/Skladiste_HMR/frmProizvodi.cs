using System;
using System.Windows.Forms;

namespace Skladiste_HMR
{
    public partial class frmProizvodi : Form
    {

        Korisnik korisnik;
        Proizvod def_proizvod = new Proizvod(null, null, -1);
        string valuta_def = "";
        double cijena_def = 0;
    
        public frmProizvodi(Korisnik k)
        {
            korisnik = k;
            InitializeComponent();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            CiscenjeProzora();
            btnBrisiPr.Hide();
            btnUrediPr.Hide();
            if (korisnik.Uloga == "radnik")
            {
                btnDodajPr.Hide();
            }
            try
            {
                def_proizvod.PrikazProizvoda(dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            IsprazniBox();
            if (korisnik.Uloga == "poslovoda")
            {
                btnBrisiPr.Show();
                btnUrediPr.Show();
                CiscenjeProzora();
                IsprazniBox();
            }
            def_proizvod.Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            def_proizvod.Naziv = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            def_proizvod.Cijena = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            PodjelaCijene();
        }

        private void btnBrisiPr_Click(object sender, EventArgs e)
        {
            if (def_proizvod.Id != -1)
            {
                DialogResult result = MessageBox.Show("Prilikom brisanja proizvoda, " +
                    "izbrisat će se i pripadajuće isporuke! Jeste li sigurni da želite izbrisati proizvod?",
                    "Upozorenje", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    def_proizvod.BrisanjeProizvoda(def_proizvod.Id);
                
                    MessageBox.Show("Uspješno izbrisan proizvod!");
                    def_proizvod.PrikazProizvoda(dataGridView1);
                    CiscenjeProzora();
                    dataGridView1.ClearSelection();
                    btnBrisiPr.Hide();
                    btnUrediPr.Hide();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Odaberite proizvod za brisanje!");
            }
        }

        private void btnDodajPr_Click(object sender, EventArgs e)
        {
            PopunjavanjeProzora();
            btnSpremiPr.Show();
            btnPromijeniPr.Hide();

            IsprazniBox();
        }

        private void btnUrediPr_Click(object sender, EventArgs e)
        {
            PopunjavanjeProzora();
            btnPromijeniPr.Show();
            btnSpremiPr.Hide();

            txtNazivPr.Text = def_proizvod.Naziv;
            txtCijenaPr.Text = cijena_def.ToString();
            cmbBoxValuta.Text = valuta_def;
        }

        private void btnPromijeniPr_Click(object sender, EventArgs e)
        {
            string proizvod = txtNazivPr.Text;
            string cijena = txtCijenaPr.Text;
            
            if (cmbBoxValuta.SelectedIndex > -1 && Provjere.KratkaProvjeraUnosa(proizvod) && Provjere.ProvjeraCijene(cijena))
            {
                string valuta = cmbBoxValuta.SelectedItem.ToString();
                def_proizvod.UredivanjeProizvoda(def_proizvod.Id, proizvod, cijena + " " + valuta);

                MessageBox.Show("Uspješno ste promijenili podatke o proizvodu!");
                def_proizvod.PrikazProizvoda(dataGridView1);
                CiscenjeProzora();
                IsprazniBox();
                dataGridView1.ClearSelection();
                btnBrisiPr.Hide();
                btnUrediPr.Hide();
            }
            else
            {
                MessageBox.Show("Niste popunili ispravno sva polja. Pokušajte ponovno!");
            }
        }

        private void btnSpremiPr_Click(object sender, EventArgs e)
        {
            string proizvod = txtNazivPr.Text;
            string cijena = txtCijenaPr.Text;
            
            if (cmbBoxValuta.SelectedIndex > -1 && Provjere.KratkaProvjeraUnosa(proizvod) && Provjere.ProvjeraCijene(cijena))
            {
                string valuta = cmbBoxValuta.SelectedItem.ToString();

                def_proizvod.DodavanjeProizvoda(proizvod, cijena + " " + valuta);

                MessageBox.Show("Uspješno ste unijeli novi proizvod!");
                def_proizvod.PrikazProizvoda(dataGridView1);
                CiscenjeProzora();
                IsprazniBox();
            }
            else
            {
                MessageBox.Show("Niste popunili ispravno sva polja. Pokušajte ponovno!");
            }
        }

        private void CiscenjeProzora()
        {
            def_proizvod.Id = -1;
            btnSpremiPr.Hide();
            btnPromijeniPr.Hide();
            txtNazivPr.Hide();
            txtCijenaPr.Hide();
            lblNazivPr.Hide();
            lblCijenaPr.Hide();
            cmbBoxValuta.Hide();
            lblValuta.Hide();
        }
        private void PopunjavanjeProzora()
        {
            txtNazivPr.Show();
            txtCijenaPr.Show();
            lblNazivPr.Show();
            lblCijenaPr.Show();
            cmbBoxValuta.Show();
            lblValuta.Show();
        }
        private void IsprazniBox()
        {
            txtNazivPr.Text = "";
            txtCijenaPr.Text = "";
            cmbBoxValuta.Text = "";
        }
        private void PodjelaCijene()
        {
            string pomocna = "";
            valuta_def = "";
            foreach (char znak in def_proizvod.Cijena)
            {
                if (Char.IsDigit(znak) || znak == '.' || znak == ',')
                {
                    if (znak == '.')
                    {
                        pomocna += ',';
                    }
                    else
                    {
                        pomocna += znak;
                    }
                }
                if (znak=='H' || znak == 'R' || znak == 'K' || znak== '€')
                {
                    valuta_def+=znak;
                }
            }
            cijena_def = double.Parse(pomocna);
        }
    }
}

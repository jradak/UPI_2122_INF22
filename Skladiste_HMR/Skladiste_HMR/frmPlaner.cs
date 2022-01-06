﻿using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace Skladiste_HMR
{
    public partial class frmPlaner : Form
    {
        Korisnik korisnik;
        Narudzba narudzba= new Narudzba(-1, DateTime.Today);
        Isporuka isporuka = new Isporuka(-1, -1, DateTime.Today, -1, -1, -1);

        public frmPlaner(Korisnik k)
        {
            korisnik = k;
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            CiscenjeProzora();
            btnBrisiNar.Hide();

            if (korisnik.Uloga == "radnik")
            {
                btnDodajNar.Hide();
            }
            try
            {
                narudzba.PrikazNarudzbi(dataGridViewNar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDodajNar_Click(object sender, EventArgs e)
        {
            PopunjavanjeProzora();
            IsprazniBox();
        }

        private void btnSpremiDodaj_Click(object sender, EventArgs e)
        {
            DateTime datum = datumNar.Value;

            if (datum != null)
            {
                narudzba.DodavanjeNarudzbi(datum);
                MessageBox.Show("Uspješno ste unijeli novu narudžbu!");
                narudzba.PrikazNarudzbi(dataGridViewNar);
                CiscenjeProzora();

                int zadnjiRed = dataGridViewNar.Rows.Count - 1;
                narudzba.Id = int.Parse(dataGridViewNar.Rows[zadnjiRed].Cells[0].Value.ToString());
                
                frmIsporuke isporuke = new frmIsporuke(narudzba.Id);
                isporuke.Show();
            }

        }

        private void dataGridViewNar_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (korisnik.Uloga == "poslovoda")
            {
                btnBrisiNar.Show();
                CiscenjeProzora();
                IsprazniBox();

                narudzba.Id= int.Parse(dataGridViewNar.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            dataGridViewIsp.Show();

            isporuka.PrikazIsporukaNarudzbe(narudzba.Id, dataGridViewIsp);
        }
       
        private void btnBrisiNar_Click(object sender, EventArgs e)
        {
            if (narudzba.Id != -1)
            {
                DialogResult result = MessageBox.Show("Prilikom brisanja narudžbe, " +
                    "izbrisat će se i pripadajuće isporuke! Jeste li sigurni da želite izbrisati narudžbu?",
                    "Upozorenje", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    narudzba.BrisanjeNarudzbe(narudzba.Id);
                    MessageBox.Show("Uspješno izbrisana narudžba!");
                    narudzba.PrikazNarudzbi(dataGridViewNar);
                    CiscenjeProzora();
                    IsprazniBox();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Odaberite narudžbu za brisanje!");
            }
        }

        private void dataGridViewNar_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmIsporuke isporuke = new frmIsporuke(narudzba.Id);
            isporuke.Show();
        }

        private void CiscenjeProzora()
        {
            narudzba.Id = -1;
            lblDatum.Hide();
            datumNar.Hide();
            btnSpremiDodaj.Hide();
            dataGridViewIsp.Hide();
        }

        private void PopunjavanjeProzora()
        {
            lblDatum.Show();
            datumNar.Show();
            btnSpremiDodaj.Show();
        }

        private void IsprazniBox()
        {
            datumNar.Value = DateTime.Today;
        }
    }
}

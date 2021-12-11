using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skladiste_HMR
{
    public partial class Form2 : Form
    {
        public Form2(string kime, string uloga)
        {
            InitializeComponent();
            lblKorIme.Text = kime;
            if (uloga == "admin")
            {
                pictureBox4.Show();
                pictureBox1.Hide();
                pictureBox2.Hide();
                pictureBox3.Hide();
            }
            else
            {
                pictureBox4.Hide();
                pictureBox1.Show();
                pictureBox2.Show();
                pictureBox3.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form4 fm4 = new Form4();
            fm4.Show();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            Sjena1.Show();
            lblInfoOdabir.Show();
            lblInfoOdabir.Text = "Planer";
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            Sjena1.Hide();
            lblInfoOdabir.Hide();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            Sjena2.Show();
            lblInfoOdabir.Show();
            lblInfoOdabir.Text = "Skladište";
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            Sjena2.Hide();
            lblInfoOdabir.Hide();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //ovo je samo primjer
            Form3 fm3 = new Form3();
            fm3.Show();
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            Sjena3.Hide();
            lblInfoOdabir.Hide();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            Sjena3.Show();
            lblInfoOdabir.Show();
            lblInfoOdabir.Text = "Proizvodi";
        }

        

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form5 fm5 = new Form5();
            fm5.Show();
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            Sjena2.Show();
            lblInfoKorR.Show();
        }
        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            Sjena2.Hide();
            lblInfoKorR.Hide();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form6 fm6 = new Form6();
            fm6.Show();
        }
        
        private void btnOdjava_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm1 = new Form1();
            fm1.Show();
        }
    }
}

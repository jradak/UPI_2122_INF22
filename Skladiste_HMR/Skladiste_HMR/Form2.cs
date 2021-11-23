﻿using System;
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
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm1 = new Form1();
            fm1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //ovo je samo primjer
            this.Hide();
            Form3 fm3 = new Form3();
            fm3.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}

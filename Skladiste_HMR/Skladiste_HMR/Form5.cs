using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Skladiste_HMR
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            button1.Hide();
            button2.Hide();
            button4.Hide();
            button5.Hide();
            textBox1.Hide();
            textBox2.Hide();
            label1.Hide();
            label2.Hide();
            try
            {
                SqlConnection con = new SqlConnection(Konstante.ConnectionString);
                SqlCommand cmd = new SqlCommand("Select * from Proizvod", con);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                //close connection
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            button1.Show();
            button2.Show();
            button4.Hide();
            button5.Hide();
            textBox1.Hide();
            textBox2.Hide();
            label1.Hide();
            label2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.Show();
            button5.Hide();
            textBox1.Show();
            textBox2.Show();
            label1.Show();
            label2.Show();
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button5.Hide();
            button4.Show();
            textBox1.Show();
            textBox2.Show();
            label1.Show();
            label2.Show();
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}

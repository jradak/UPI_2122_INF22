using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Skladiste_HMR
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            button1.Hide();
            button2.Hide();
            button4.Hide();
            button5.Hide();
            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            comboBox1.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            try
            {
                SqlConnection con = new SqlConnection(Konstante.ConnectionString);
                SqlCommand cmd = new SqlCommand("Select * from Korisnik", con);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                //close connection
                con.Close();
            }
            catch(Exception ex)
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
            textBox3.Hide();
            textBox4.Hide();
            comboBox1.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Show();
            textBox2.Show();
            textBox3.Show();
            textBox4.Show();
            comboBox1.Show();
            button4.Show();
            button5.Hide();

            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Show();
            textBox2.Show();
            textBox3.Show();
            textBox4.Show();
            comboBox1.Show();
            button4.Hide();
            button5.Show();

            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}

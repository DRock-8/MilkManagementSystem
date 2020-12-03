using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace firstApplication
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            label4.Text = DateTime.Now.ToString();


            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=milk;uid=root;pwd=1234;";
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();

                string sql = "select sum(qty) as total from purchase where milkType='COW'";

                Console.WriteLine(sql);
                MySqlCommand cmd = new MySqlCommand(sql, cnn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                //DataTable dt = new DataTable();
                //dt.Load(rdr);
                //dataGridView1.DataSource = dt;

                rdr.Read();
                cowStock.Text = rdr["total"].ToString();

                rdr.Close();
                cnn.Close();
                // MessageBox.Show("Customer details updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            string connetionString1 = null;
            MySqlConnection cnn1;
            connetionString1 = "server=localhost;database=milk;uid=root;pwd=1234;";
            cnn1 = new MySqlConnection(connetionString1);
            try
            {
                cnn.Open();

                string sql = "select sum(qty) as total from purchase where milkType='BUFFALO'";

                Console.WriteLine(sql);
                MySqlCommand cmd = new MySqlCommand(sql, cnn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                rdr.Read();
                buffaloStock.Text = rdr["total"].ToString();

             

                rdr.Close();
                cnn.Close();
                // MessageBox.Show("Customer details updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 adminObj = new Form6();
            adminObj.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HOME adminObj = new HOME();
            adminObj.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            

           
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // label4.Text = DateTime.Now.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}

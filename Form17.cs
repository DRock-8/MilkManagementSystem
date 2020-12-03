using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace firstApplication
{
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void Form17_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fromdate = fromDate.Text;
            String todate = toDate.Text;
            String Search = search.Text;

            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=milk;uid=root;pwd=1234;";
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();

                // string sql = "select * from purchase";
                string sql = "select customer.name,Address,mobile_no,sum(qty) as total_qty,sum(totalamt) as totalamt from customer join purchase where date between '" + fromdate + "' and '" + todate + "' and customer.name='" + Search + "' and customer.name=purchase.name";



                Console.WriteLine(sql);
                MySqlCommand cmd = new MySqlCommand(sql, cnn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(rdr);
                dataGridView1.DataSource = dt;

                rdr.Close();
                cnn.Close();
                // MessageBox.Show("Customer details updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String fromdate = fromDate.Text;
            String todate = toDate.Text;
            String Search = search.Text;

            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=milk;uid=root;pwd=1234;";
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();

                // string sql = "select * from purchase";
                string sql = "select customer.name,Address,mobile_no,sum(qty) as total_qty,sum(totalamt) as totalamt from customer join purchase where date between '" + fromdate + "' and '" + todate + "' and purchase.name='" + Search + "' and customer.name=purchase.name and payment_status='Not Paid'";



                Console.WriteLine(sql);
                MySqlCommand cmd = new MySqlCommand(sql, cnn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(rdr);
                dataGridView1.DataSource = dt;

                rdr.Close();
                cnn.Close();
                // MessageBox.Show("Customer details updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HOME adminObj = new HOME();
            adminObj.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form10 adminObj = new Form10();
            adminObj.Show();
            this.Hide();
        }

      

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
             String fromdate = fromDate.Text;
            String todate = toDate.Text;
            String Search = search.Text;
            String Status = status.Text;

            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=milk;uid=root;pwd=1234;";
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();

                string sql = "update purchase set payment_status= '"+ Status +"' where date between '" + fromdate + "' and '" + todate + "' and name='" + Search +"'";
               
                Console.WriteLine(sql);
                MySqlCommand cmd = new MySqlCommand(sql, cnn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(rdr);
                dataGridView1.DataSource = dt;

                rdr.Close();
                cnn.Close();
                MessageBox.Show("payment status updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
         
            search.Clear();
        }

        private void status_TextChanged(object sender, EventArgs e)
        {

        }

        private void status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

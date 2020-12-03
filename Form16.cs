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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void Form16_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HOME adminObj = new HOME();
            adminObj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ARE YOU SURE!!! YOU WANT TO DELETE");
            String custname = custName.Text;
            //String custaddr = addr.Text;
           // String custmob = mobileNo.Text;

            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=milk;uid=root;pwd=1234;";
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();

                string sql = "DELETE from customer where Name =" + '"' + custname + '"';

                Console.WriteLine(sql);
                MySqlCommand cmd = new MySqlCommand(sql, cnn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                rdr.Close();
                cnn.Close();
                MessageBox.Show("Customer deleted successfully");
                custName.Clear();

                Form12 adminObj = new Form12();
                adminObj.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form12 adminObj = new Form12();
            adminObj.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            custName.Clear();
        }
    }
}

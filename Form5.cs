using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace firstApplication
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HOME adminObj = new HOME();
            adminObj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String custname = custName.Text;
            String custaddr = custAddr.Text;
            String custmob = custMobileNo.Text;

            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=milk;uid=root;pwd=1234;";
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();

                string sql = "insert into customer(Name, Address, Mobile_No) values(" + "'"+custname + "'"+", " + "'"+custaddr + "'"+", " + custmob + ");";
                Console.WriteLine(sql);
                // string sql = "SELECT * from customer";
                MySqlCommand cmd = new MySqlCommand(sql, cnn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0] + " -- " + rdr[1]);
                }
                rdr.Close();
                cnn.Close();
                MessageBox.Show("Customer added successfully");
                custName.Clear();
                custMobileNo.Clear();
                custAddr.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void custName_TextChanged(object sender, EventArgs e)
        {

        }

        private void custAddr_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

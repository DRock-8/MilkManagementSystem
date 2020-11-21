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
using System.Windows.Forms;


namespace firstApplication
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HOME adminObj = new HOME();
            adminObj.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form12 adminObj = new Form12();
            adminObj.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String custname = custName.Text;
            String custaddr = addr.Text;
            String custmob = mobileNo.Text;

            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=milk;uid=root;pwd=1234;";
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();

                string sql = "update customer set Address = "+'"'+ custaddr + '"' + ", Mobile_No="+'"'+ custmob +'"'+ " where Name ="+'"'+custname+'"';

                Console.WriteLine(sql);
                MySqlCommand cmd = new MySqlCommand(sql, cnn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                rdr.Close();
                cnn.Close();
                MessageBox.Show("Customer details updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox mybox = new ComboBox();
            mybox.Items.Add("afdsfsdsdf");
        }

        
        private void custName_TextChanged(object sender, EventArgs e)
        {
            
                //string customerName = custName.Text;
                //string connetionString = null;
                //MySqlConnection cnn;
                //connetionString = "server=localhost;database=milk;uid=root;pwd=1234;";
                //cnn = new MySqlConnection(connetionString);
                //try
                //{
                //    cnn.Open();

                //    string sql = "select * from customer where Name like " + "'" + customerName + "'";
                //    Console.WriteLine(sql);
                //    MySqlCommand cmd = new MySqlCommand(sql, cnn);
                //    MySqlDataReader rdr = cmd.ExecuteReader();
                //    while (rdr.Read())
                //    {
                //        Console.WriteLine(rdr[0] + " -- " + rdr[1]);
                //    }
                //    rdr.Close();
                //    cnn.Close();
                //    addr.Text = rdr[2].ToString();
                //    mobileNo.Text = rdr[3].ToString();

                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine("exception " + ex);
                //}
            
            
        }

        private void addr_TextChanged(object sender, EventArgs e)
        {

        }

    }
}

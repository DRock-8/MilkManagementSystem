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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Date = date.Text;
            String custname = custName.Text;
            String milktype = milkType.Text;
            String Rate = rate.Text;
            String Qty = qty.Text;
            String ttAmt = ttamt.Text;

            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=milk;uid=root;pwd=1234;";
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();

                string sql = "insert into purchase(date,Name,milkType,rate,qty,totalamt) values(" + "'" + Date + "'" + ", " + "'" + custname + "'" + "," + "'" + milktype + "'" + "," + "'" + Rate + "'" + "," + "'" + Qty + "'" + "," + ttAmt + ");";
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
                MessageBox.Show("Record added successfully");
                //custName.Clear();
                //custMobileNo.Clear();
                // custAddr.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            int totalAmount = int.Parse(qty.Text) * int.Parse(rate.Text) ;
            ttamt.Text = totalAmount.ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            HOME adminObj = new HOME();
            adminObj.Show();
            this.Hide();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 adminObj = new Form7();
            adminObj.Show();
            this.Hide();
        }
    }
}

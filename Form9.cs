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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        class Global
        {
            public static string custname;
            public static string Qty;
            public static string Rate;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
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
            
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void milkType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String Date = date.Text;
            Global.custname = custName.Text;
            String milktype = milkType.Text;
            Global.Rate = rate.Text;
            String Fat = fat.Text;
            Global.Qty = qty.Text;
            String ttAmt = ttamt.Text;

            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=milk;uid=root;pwd=1234;";
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();

                string sql = "insert into sell(date,Name,milkType,fat,rate,qty,totalamt) values(" + "'" + Date + "'" + ", " + "'" + Global.custname + "'" + ", " + "'" + milktype + "'" + ", " + "'" + Fat + "'" + "," + "'" + Global.Rate + "'" + "," + "'" + Global.Qty + "'" + "," + ttAmt + ");";
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
            if (Global.custname != "")
            {
                custName.Clear();
            }
            if (Global.Qty != "")
            {
                qty.Clear();
            }

            if (Global.Rate != "")
            {
                fat.Clear();
                rate.Clear();
                ttamt.Clear();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            HOME adminObj = new HOME();
            adminObj.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form7 adminObj = new Form7();
            adminObj.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            if (Global.custname != "")
            {
                custName.Clear();
            }
            if (Global.Qty != "")
            {
                qty.Clear();
            }
            if (Global.Rate != "")
            {
                rate.Clear();
                ttamt.Clear();
            }
        }

        private void rate_TextChanged(object sender, EventArgs e)
        {

            try
            {
                int totalAmount = int.Parse(qty.Text) * int.Parse(rate.Text);
                ttamt.Text = totalAmount.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("exception --" + ex.Message);

                //MessageBox.Show(ex.ToString());
            }

        }

        private void button5_Click(object sender, EventArgs e)
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
                string sql = "select * from sell where date between '" + fromdate + "' and '" + todate + "' or name='" + Search + "'";



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

        private void custName_TextChanged(object sender, EventArgs e)
        {
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=milk;uid=root;pwd=1234;";
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();

                string sql = "select * from sell ";



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

        private void search_TextChanged(object sender, EventArgs e)
        {

            String Search = search.Text;

            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=milk;uid=root;pwd=1234;";
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();

                // string sql = "select * from purchase";
                string sql = "select * from sell where name like'" + Search + "%'";



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

        private void fat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float fatValue = float.Parse(fat.Text);
                float Rate = 0;
                if (fatValue >= 5 && fatValue <= 6 && milkType.Text == "COW")
                {
                    Rate = 38;
                    MessageBox.Show("Good quality of Milk !!!");
                }
                else if (fatValue >= 4 && fatValue <= 5 && milkType.Text == "COW")
                {
                    Rate = 35;
                    MessageBox.Show("Medium quality of Milk !!!");
                }
                else if (fatValue >= 3 && fatValue <= 4 && milkType.Text == "COW")
                {
                    Rate = 32;
                    MessageBox.Show("Poor quality of Milk !!!");
                }
                else if (fatValue >= 6 && fatValue <= 7 && milkType.Text == "BUFFALO")
                {
                    Rate = 55;
                    MessageBox.Show("Good quality of Milk !!!");
                }
                else if (fatValue >= 5 && fatValue <= 6 && milkType.Text == "BUFFALO")
                {
                    Rate = 50;
                    MessageBox.Show("Medium quality of Milk !!!");
                }
                else if (fatValue >= 4 && fatValue <= 5 && milkType.Text == "BUFFALO")
                {
                    Rate = 45;
                    MessageBox.Show("Poor quality of Milk !!!");
                }
                rate.Text = Rate.ToString();
                int totalAmount = int.Parse(qty.Text) * int.Parse(rate.Text);
                ttamt.Text = totalAmount.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("exception --" + ex.Message);

                //MessageBox.Show(ex.ToString());
            }
        }
    }
}

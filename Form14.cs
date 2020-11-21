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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            HOME adminObj = new HOME();
            adminObj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 adminObj = new Form10();
            adminObj.Show();
            this.Hide();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            String fromdate = fromDate.Text;
            String todate = toDate.Text;
            // String custmob = mobileNo.Text;

            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=milk;uid=root;pwd=1234;";
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();

                string sql = "select * from purchase where date between "+'"' +fromdate +'"' + "and" + '"'+ todate +'"';

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

        private void toDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void fromDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

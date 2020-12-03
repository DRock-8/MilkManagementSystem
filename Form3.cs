using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstApplication
{
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {

            Form12 adminObj = new Form12();
            adminObj.Show();
            this.Hide();

           
        }

        private void transactionBtn_Click(object sender, EventArgs e)
        {
            Form7 adminObj = new Form7();
            adminObj.Show();
            this.Hide();
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            Form10 adminObj = new Form10();
            adminObj.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 adminObj = new Form4();
            adminObj.Show();
            this.Hide();
           
        }
    }
}

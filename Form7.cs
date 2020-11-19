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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
          
                Form8 adminObj = new Form8();
                adminObj.Show();
                this.Hide();
           
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 adminObj = new Form9();
            adminObj.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HOME adminObj = new HOME();
            adminObj.Show();
            this.Hide();
        }
    }
}

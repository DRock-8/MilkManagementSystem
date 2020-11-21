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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HOME adminObj = new HOME();
            adminObj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 adminObj = new Form10();
            adminObj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            this.Hide();
        }
    }
}

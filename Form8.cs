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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HOME adminObj = new HOME();
                adminObj.Show();
                this.Hide();
           
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String defaultUsername = "Deepak";
            String defaultPassword = "abc";
            String name = username.Text;
            String password = passinput.Text;

            // MessageBox.Show(name + password);

            

            if (defaultUsername == name && defaultPassword == password)
            {
                HOME obj1 = new HOME();
                obj1.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            passinput.Clear();
            username.Clear();
        }
    }
}

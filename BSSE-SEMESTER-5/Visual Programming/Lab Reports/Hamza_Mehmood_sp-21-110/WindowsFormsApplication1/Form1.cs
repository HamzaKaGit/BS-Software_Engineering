using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string name = textBox1.Text;
            string pass = textBox2.Text;
           
           // MessageBox.Show(name + " " + pass);
            if (name=="Hamza" && pass == "123")
            {
               // MessageBox.Show("Login Successful");
                textBox3.Text = "Login Successful";
            }
            else
            {
                textBox3.Text = "Invalid Credentials";
                //MessageBox.Show("Invalid Credentials");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = comboBox1.Text;
            MessageBox.Show(name);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
       
        }
    }
}

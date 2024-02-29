using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculation;

namespace WinFormsApp_class_library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Calculate cal = new Calculate();
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                //storing the result in int i   
                int  i= cal.Add(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
                textBox3.Text = i.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //storing the result in int i   
                int i = cal.Sub(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
                textBox3.Text = i.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                //storing the result in int i   
                int i = cal.Mul(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
                textBox3.Text = i.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        int _ticks;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);

           

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.progressBar1.Increment(trackBar1.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            _ticks++;
            this.Text = _ticks.ToString();

            if (_ticks == 10)
            {
                this.Text = "Times UP";
                timer2.Stop();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = dateTimePicker1.Text;
        }
    }
}

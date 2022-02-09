using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int soucin = a * b;
            label1.Text = string.Format("Soucin cisel {0} a {1} je {2}", a, b, soucin);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int odcitani = a - b;
            label1.Text = string.Format("Soucin cisel {0} a {1} je {2}", a, b, odcitani);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int soucet = a + b;
            label1.Text = string.Format("Soucin cisel {0} a {1} je {2}", a, b, soucet);
        }
    }
}

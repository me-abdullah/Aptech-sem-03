using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int val1 = int.Parse(textBox1.Text);
            int val2 = int.Parse(textBox2.Text);

            int result = val1 + val2;

            MessageBox.Show("The result is: " + result.ToString(), "Calculation Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int val1 = int.Parse(textBox1.Text);
            int val2 = int.Parse(textBox2.Text);

            int result = val1 - val2;

            MessageBox.Show("The result is: " + result.ToString(), "Calculation Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int val1 = int.Parse(textBox1.Text);
            int val2 = int.Parse(textBox2.Text);

            int result = val1 * val2;

            MessageBox.Show("The result is: " + result.ToString(), "Calculation Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int val1 = int.Parse(textBox1.Text);
            int val2 = int.Parse(textBox2.Text);

            int result = val1 / val2;

            MessageBox.Show("The result is: " + result.ToString(), "Calculation Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

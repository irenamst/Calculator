using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float Fahrenheit = float.Parse(textBox1.Text);
            float Celsius = (Fahrenheit - 32) * 5.0f / 9.0f;
            textBox2.Text = Celsius.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float Celsius = float.Parse(textBox2.Text);
            float Fahrenheit = (Celsius * 9.0f) / 5.0f + 32;
            textBox1.Text = Fahrenheit.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

            textBox2.Text = "";
        }
    }
}

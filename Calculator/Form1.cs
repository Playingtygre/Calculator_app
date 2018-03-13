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

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            Button button =(Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            //textBox1.Text = textBox1.Text + "2";
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fun_Multifunctional_Application__FMA_
{
    public partial class Form1 : Form
    {

        Color color;

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (ended)
            {
                ended = false;
                textBox1.Text = "0";
            }
            Button B = (Button)sender;
            if (textBox1.Text == "0") textBox1.Text = B.Text; else
                textBox1.Text = textBox1.Text + B.Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        public String N1;
        public String operation;
        public Boolean ended;

        private void button2_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            operation = B.Text;
            N1 = textBox1.Text;
            ended = true;

            textBox2.Text = N1 + " " + operation;
        }

        public double res;
        public String lastOperation;
        public double lastDig;

        private void button10_Click(object sender, EventArgs e)
        {
            double d1, d2;

            d1 = Convert.ToDouble(N1);
            d2 = Convert.ToDouble(textBox1.Text);
            if (operation == "") { operation = lastOperation; d1 = d2; d2 = lastDig; }
            switch (operation)
            {
                case "÷":
                    res = d1 / d2;
                    break;
                case "×":
                    res = d1 * d2;
                    break;
                case "-":
                    res = d1 - d2;
                    break;
                case "+":
                    res = d1 + d2;
                    break;
            }
            lastOperation = operation;
            lastDig = d2;
            operation = "";
            ended = true;
            textBox1.Text = res.ToString();
            textBox2.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double dn2;

            dn2 = Convert.ToDouble(textBox1.Text);

            Button f = (Button)(sender);

            switch (f.Text)
            {
                case "√":
                    textBox1.Text = Math.Sqrt(dn2).ToString();
                    textBox2.Text = "√(" + dn2 + ")";
                    break;
                case "x^2":
                    textBox1.Text = (dn2*dn2).ToString();
                    textBox2.Text = "sqr(" + dn2 + ")";
                    break;
                case "1/x":
                    textBox1.Text = (1/dn2).ToString();
                    textBox2.Text = "1/(" + dn2 + ")";
                    break;
            }

            ended = true;
        }
    }
}

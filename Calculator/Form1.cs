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
        double total = 0;
        Operation operation = Operation.None;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += button1.Text;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += button2.Text;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += button3.Text;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += button4.Text;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += button5.Text;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += button6.Text;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += button7.Text;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += button8.Text;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += button9.Text;
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += button10.Text;
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += button11.Text;
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            total = 0;
            operation = Operation.None;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            total = Compute();
            operation = Operation.Addition;
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            total = Compute();
            operation = Operation.Subtraction;
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            total = Compute();
            operation = Operation.Multiplication;
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            total = Compute();
            operation = Operation.Division;
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            if(operation != Operation.None)
            {
                txtDisplay.Text = Compute().ToString();
                operation = Operation.None;
                total = 0;
            }
        }

        private double Compute()
        {
            double result = double.Parse(txtDisplay.Text);
            if (operation == Operation.Addition)
            {
                result = total + double.Parse(txtDisplay.Text);
            }
            else if (operation == Operation.Subtraction)
            {
                result = total - double.Parse(txtDisplay.Text);
            }
            else if (operation == Operation.Multiplication)
            {
                result = total * double.Parse(txtDisplay.Text);
            }
            else if (operation == Operation.Division)
            {
                result = total / double.Parse(txtDisplay.Text);
            }
            txtDisplay.Clear();
            return result;
        }
    }
}

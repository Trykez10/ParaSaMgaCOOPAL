using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalcGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double result;
        private double num1, num2;
        private string option;

        private void btn0_Click(object sender, EventArgs e)
        {
            outputDisplay.Text += btn0.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            outputDisplay.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            outputDisplay.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            outputDisplay.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            outputDisplay.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            outputDisplay.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            outputDisplay.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            outputDisplay.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            outputDisplay.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            outputDisplay.Text += btn9.Text;
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
           option = "+"; 
           num1 = double.Parse(outputDisplay.Text);

           outputDisplay.Clear();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = double.Parse(outputDisplay.Text);

            outputDisplay.Clear();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = double.Parse(outputDisplay.Text);

            outputDisplay.Clear();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = double.Parse(outputDisplay.Text);

            outputDisplay.Clear();
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            outputDisplay.Text += btnDecimal.Text;
        }

        private void outputDisplay_TextChanged(object sender, EventArgs e)
        {
        }

        private void clear_Click(object sender, EventArgs e)
        {
            outputDisplay.Clear();
            num1 = 0;
            num2 = 0;
            result = 0;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(outputDisplay.Text);

            if (option.Equals("+"))
            {
                result = num1 + num2;
            }
            else if (option.Equals("-"))
            {
                result = num1 - num2;
            }
            else if (option.Equals("*"))
            {
                result = num1 * num2;
            }
            else if (option.Equals("/"))
            {
                try
                {
                    result = num1 / num2;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Choice not valid", "Note", MessageBoxButtons.OK);
            }
            outputDisplay.Text = result.ToString();
        }



    }
}

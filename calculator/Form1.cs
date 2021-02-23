using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool number = false;
        int ans;

        private void label1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Made by Vorkys")
            {
                label1.Text = "Made by Erik";
            }
            else
            {
                label1.Text = "Made by Vorkys";
            }
        }

        private void screen_Click(object sender, EventArgs e)
        {

        }

        private void zero_Click(object sender, EventArgs e)
        {
            screen.Text += "0";
            if (number == false)
            {
                num1.Text += "0";
            }
            else
            {
                num2.Text += "0";
            }
        }

        private void one_Click(object sender, EventArgs e)
        {
            screen.Text += "1";
            if (number == false)
            {
                num1.Text += "1";
            }
            else
            {
                num2.Text += "1";
            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            screen.Text += "2";
            if (number == false)
            {
                num1.Text += "2";
            }
            else
            {
                num2.Text += "2";
            }
        }

        private void three_Click(object sender, EventArgs e)
        {
            screen.Text += "3";
            if (number == false)
            {
                num1.Text += "3";
            }
            else
            {
                num2.Text += "3";
            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            screen.Text += "4";
            if (number == false)
            {
                num1.Text += "4";
            }
            else
            {
                num2.Text += "4";
            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            screen.Text += "5";
            if (number == false)
            {
                num1.Text += "5";
            }
            else
            {
                num2.Text += "5";
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            screen.Text += "6";
            if (number == false)
            {
                num1.Text += "6";
            }
            else
            {
                num2.Text += "6";
            }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            screen.Text += "7";
            if (number == false)
            {
                num1.Text += "7";
            }
            else
            {
                num2.Text += "7";
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            screen.Text += "8";
            if (number == false)
            {
                num1.Text += "8";
            }
            else
            {
                num2.Text += "8";
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            screen.Text += "9";
            if (number == false)
            {
                num1.Text += "9";
            }
            else
            {
                num2.Text += "9";
            }
        }

        private void addi_Click(object sender, EventArgs e)
        {
            screen.Text += "+";
            number = true;
            operation.Text = "+";
        }

        private void subt_Click(object sender, EventArgs e)
        {
            screen.Text += "-";
            number = true;
            operation.Text = "-";
        }

        private void multip_Click(object sender, EventArgs e)
        {
            screen.Text += "X";
            number = true;
            operation.Text = "X";
        }

        private void divi_Click(object sender, EventArgs e)
        {
            screen.Text += "/";
            number = true;
            operation.Text = "/";
        }

        private void dele_Click(object sender, EventArgs e)
        {
            
        }

        private void clear_Click(object sender, EventArgs e)
        {
            screen.Text = "";
            
            number = false;
            num1.Text = "";
            num2.Text = "";
            operation.Text = "";
            ending.Text = "";
        }

        private void coma_Click(object sender, EventArgs e)
        {
            screen.Text += ".";
            if (number == false)
            {
                num1.Text += ".";
            }
            else
            {
                num2.Text += ".";
            }

        }

        private void equal_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(num1.Text);
            double y = Convert.ToDouble(num2.Text);
            string z = Convert.ToString(operation.Text);

            if (z == "+")
            {
                ending.Text = (x + y).ToString();
                ans = (int)(x + y);
            }
            else if (z == "X")
            {
                ending.Text = (x * y).ToString();
                ans = (int)(x * y);
            }
            else if (z == "/")
            {
                ending.Text = (x / y).ToString();
                ans = (int)(x / y);
            }
            else if (z == "-")
            {
                ending.Text = (x - y).ToString();
                ans = (int)(x - y);
            }
        }

        private void button1_Click(object sender, EventArgs e)      /*ANS*/
        {
            if (number == false)
            {
                num1.Text += ans;
            }
            else
            {
                num2.Text += ans;
            }
        }

        private void braces_Click(object sender, EventArgs e)       /*zavorky*/
        {

        }
    }
}

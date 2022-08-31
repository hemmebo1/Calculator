using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Calculator
{
    public partial class Form1 : Form
    {

        double FirstNumber;
        string Operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //min knapp för 1
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        //min knapp för 2
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        //min knapp för 3
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        //min knapp för 4
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        //min knapp för 5
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        //min knapp för 6
        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        //min knapp för 7
        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        //min knapp för 8
        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        //min knapp för 9
        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }
        //min knapp för 0
        private void button0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        //min knapp för att dela
        private void button11_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "/";
        }

        //min knapp för minus
        private void button10_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "-";
        }

        //min knapp för plus
        private void button9_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "+";
        }

        //min knapp för gånger
        private void button13_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "*";
        }

        //min knapp för clear
        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        //min knapp för punkt
        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

            //button för PI
            private void button10_Click_1(object sender, EventArgs e)
            {
                textBox1.Text = textBox1.Text + "3.1415926535897932384626433832795";
            }

            

        //min knapp för lika med
        private void button14_Click(object sender, EventArgs e)
        {
            
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(textBox1.Text);

                if (Operation == "+")
                {
                    Result = (FirstNumber + SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
                if (Operation == "-")
                {
                    Result = (FirstNumber - SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
                if (Operation == "*")
                {
                    Result = (FirstNumber * SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
                if (Operation == "/")
                {
                    if (SecondNumber == 0)
                    {
                        textBox1.Text = "Kan ej dela med 0";

                    }
                    else
                    {
                        Result = (FirstNumber / SecondNumber);
                        textBox1.Text = Convert.ToString(Result);
                        FirstNumber = Result;
                    }
                }
            }

            
        }
    }


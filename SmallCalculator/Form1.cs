using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallCalculator
{
    public partial class Form1 : Form
    {

        double summ = 0;
        int summTrigger = 0;
        int minusTriger = 0;
        int multyplyTriger = 0;
        int deleteTriger = 0;
        int stupenTriger = 0;
        int finalTriger = 0;
        string lastAction = "";

        public Form1()
        {
            InitializeComponent();
        }

        /*private void eventHandler(string ev) 
        {
            if (lastAction.Equals(""))
            {
                summ = double.Parse(label1.Text);
                lastAction = "";
                return;
            }
            if (lastAction.Equals("pluss"))
            {
                double sbtr = double.Parse(label1.Text);
                summ = summ + sbtr;
                Console.WriteLine(summ);
                label1.Text = summ.ToString();
                if (ev.Equals("minus"))
                {
                    summTrigger = 1;
                    minusTriger = 0;
                    lastAction = "pluss";
                } else if (ev.Equals("multiply")) 
                {
                    summTrigger = 1;
                    multyplyTriger = 0;
                    lastAction = "pluss";
                }
                else if (ev.Equals("deletion"))
                {
                    summTrigger = 1;
                    deleteTriger = 0;
                    lastAction = "pluss";
                }
                else if (ev.Equals("stupen"))
                {
                    summTrigger = 1;
                    stupenTriger = 0;
                    lastAction = "pluss";
                }
                else if (ev.Equals(""))
                {
                    summTrigger = 0;
                    lastAction = "";
                }
                return;
            }
            if (lastAction.Equals("minus"))
            {
                double sbtr = double.Parse(label1.Text);
                summ = summ - sbtr;
                Console.WriteLine(summ);
                label1.Text = summ.ToString();
                if (ev.Equals("pluss"))
                {
                    summTrigger = 0;
                    minusTriger = 1;
                    lastAction = "minus";
                }
                else if (ev.Equals("multiply"))
                {
                    minusTriger = 1;
                    multyplyTriger = 0;
                    lastAction = "minus";
                }
                else if (ev.Equals("deletion"))
                {
                    minusTriger = 1;
                    deleteTriger = 0;
                    lastAction = "minus";
                }
                else if (ev.Equals("stupen"))
                {
                    minusTriger = 1;
                    stupenTriger = 0;
                    lastAction = "minus";
                }
                else if (ev.Equals(""))
                {
                    minusTriger = 0;
                    lastAction = "";
                }
                return;
            }
            if (lastAction.Equals("multiply"))
            {
                double mpl = double.Parse(label1.Text);
                summ = summ * mpl;
                Console.WriteLine(summ);
                label1.Text = summ.ToString();
                if (ev.Equals("minus"))
                {
                    multyplyTriger = 1;
                    minusTriger = 0;
                    lastAction = "multiply";
                }
                else if (ev.Equals("pluss"))
                {
                    multyplyTriger = 1;
                    summTrigger = 0;
                    lastAction = "multiply";
                }
                else if (ev.Equals("deletion"))
                {
                    multyplyTriger = 1;
                    deleteTriger = 0;
                    lastAction = "multiply";
                }
                else if (ev.Equals("stupen"))
                {
                    multyplyTriger = 1;
                    stupenTriger = 0;
                    lastAction = "multiply";
                }
                else if (ev.Equals(""))
                {
                    multyplyTriger = 0;
                    lastAction = "";
                }
                return;
            }
            if (lastAction.Equals("deletion"))
            {
                double dl = double.Parse(label1.Text);
                summ = summ / dl;
                Console.WriteLine(summ);
                label1.Text = summ.ToString();
                if (ev.Equals("minus"))
                {
                    deleteTriger = 1;
                    minusTriger = 0;
                    lastAction = "deletion";
                }
                else if (ev.Equals("pluss"))
                {
                    deleteTriger = 1;
                    summTrigger = 0;
                    lastAction = "deletion";
                }
                else if (ev.Equals("multiply"))
                {
                    multyplyTriger = 0;
                    deleteTriger = 1;
                    lastAction = "deletion";
                }
                else if (ev.Equals("stupen"))
                {
                    stupenTriger = 1;
                    deleteTriger = 0;
                    lastAction = "deletion";
                }
                else if (ev.Equals(""))
                {
                    deleteTriger = 0;
                    lastAction = "";
                }
                return;
            }
            if (lastAction.Equals("stupen"))
            {
                double stp = double.Parse(label1.Text);
                summ = Math.Pow(summ, stp);
                Console.WriteLine(summ);
                label1.Text = summ.ToString();
                if (ev.Equals("minus"))
                {
                    stupenTriger = 1;
                    minusTriger = 0;
                    lastAction = "stupen";
                }
                else if (ev.Equals("pluss"))
                {
                    stupenTriger = 1;
                    summTrigger = 0;
                    lastAction = "stupen";
                }
                else if (ev.Equals("multiply"))
                {
                    stupenTriger = 1;
                    deleteTriger = 1;
                    lastAction = "stupen";
                }
                else if (ev.Equals("stupen"))
                {
                    stupenTriger = 1;
                    deleteTriger = 0;
                    lastAction = "stupen";
                }
                else if (ev.Equals(""))
                {
                    deleteTriger = 0;
                    lastAction = "";
                }
                return;
            }
        }*/

        private void buttonsHandler(string value) {
            if (textBox1.Text.Equals("0"))
            {
                textBox1.Text = value;
            }
            else if (summTrigger > 0)
            {
                textBox1.Text = value;
                summTrigger = 0;
            }
            else if (minusTriger > 0)
            {
                textBox1.Text = value;
                minusTriger = 0;
            }
            else if (multyplyTriger > 0)
            {
                textBox1.Text = value;
                multyplyTriger = 0;
            }
            else if (deleteTriger > 0)
            {
                textBox1.Text = value;
                deleteTriger = 0;
            }
            else if (stupenTriger > 0)
            {
                textBox1.Text = value;
                stupenTriger = 0;
            }
            else if (finalTriger > 0)
            {
                textBox1.Text = value;
                finalTriger = 0;
            }
            else
            {
                textBox1.Text = textBox1.Text + value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonsHandler("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonsHandler("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttonsHandler("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buttonsHandler("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buttonsHandler("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            buttonsHandler("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            buttonsHandler("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            buttonsHandler("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            buttonsHandler("9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            buttonsHandler("0");
        }

        private void buttonSumm_Click(object sender, EventArgs e)
        {
            if (lastAction.Equals("minus")) 
            { 
                double sbtr = double.Parse(textBox1.Text);
                summ = summ - sbtr;
                Console.WriteLine(summ);
                textBox1.Text = summ.ToString();
                minusTriger = 0;
                summTrigger = 1;
                multyplyTriger = 0;
                lastAction = "pluss";
                return;
            }
            if (lastAction.Equals("multiply"))
            {
                double mpl = double.Parse(textBox1.Text);
                summ = summ * mpl;
                Console.WriteLine(summ);
                textBox1.Text = summ.ToString();
                multyplyTriger = 0;
                summTrigger = 1;
                lastAction = "pluss";
                return;
            }
            if (lastAction.Equals("deletion"))
            {
                double dl = double.Parse(textBox1.Text);
                summ = summ / dl;
                Console.WriteLine(summ);
                textBox1.Text = summ.ToString();
                deleteTriger = 0;
                summTrigger = 1;
                lastAction = "pluss";
                return;
            }
            if (lastAction.Equals("stupen"))
            {
                double stp = double.Parse(textBox1.Text);
                summ = Math.Pow(summ, stp);
                Console.WriteLine(summ);
                textBox1.Text = summ.ToString();
                stupenTriger = 0;
                summTrigger = 1;
                lastAction = "pluss";
                return;
            }
            double number = double.Parse(textBox1.Text);              
            summ = summ + number;
            Console.WriteLine(summ);
            textBox1.Text = summ.ToString();
            summTrigger = 1;
            lastAction = "pluss";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (lastAction.Equals("")) 
            {
                summ=double.Parse(textBox1.Text);
                minusTriger = 1;
                Console.WriteLine(summ);
                lastAction = "minus";
                return;
            }
            if (lastAction.Equals("pluss"))
            {
                double sbtr = double.Parse(textBox1.Text);
                summ = summ + sbtr;
                Console.WriteLine(summ);
                textBox1.Text = summ.ToString();
                Console.WriteLine(summ.ToString());
                minusTriger = 1;
                summTrigger = 0;
                multyplyTriger = 0;
                lastAction = "minus";
                return;
            }
            if (lastAction.Equals("multiply"))
            {
                double mpl = double.Parse(textBox1.Text);
                summ = summ * mpl;
                Console.WriteLine(summ);
                textBox1.Text = summ.ToString();
                multyplyTriger = 0;
                minusTriger = 1;
                lastAction = "minus";
                return;
            }
            if (lastAction.Equals("deletion"))
            {
                double dl = double.Parse(textBox1.Text);
                summ = summ / dl;
                Console.WriteLine(summ);
                textBox1.Text = summ.ToString();
                deleteTriger = 0;
                minusTriger = 1;
                lastAction = "minus";
                return;
            }
            if (lastAction.Equals("stupen"))
            {
                double stp = double.Parse(textBox1.Text);
                summ = Math.Pow(summ, stp);
                Console.WriteLine(summ);
                textBox1.Text = summ.ToString();
                stupenTriger = 0;
                minusTriger = 1;
                lastAction = "minus";
                return;
            }
            double subtr = double.Parse(textBox1.Text);
            summ = summ-subtr;
            Console.WriteLine(summ);
            textBox1.Text = summ.ToString();
            minusTriger = 1;
            lastAction = "minus";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (lastAction.Equals(""))
            {
                summ = double.Parse(textBox1.Text);               
                multyplyTriger = 1;
                lastAction = "multiply";
                return;
            }
            if (lastAction.Equals("pluss"))
            {
                double sbtr = double.Parse(textBox1.Text);
                summ = summ + sbtr;
                textBox1.Text = summ.ToString();
                summTrigger = 0;
                multyplyTriger = 1;
                lastAction = "multiply";
                return;
            }
            if (lastAction.Equals("minus"))
            {
                double sbtr = double.Parse(textBox1.Text);
                summ = summ - sbtr;
                textBox1.Text = summ.ToString();
                minusTriger = 0;
                multyplyTriger = 1;
                lastAction = "multiply";
                return;
            }
            if (lastAction.Equals("deletion"))
            {
                double dl = double.Parse(textBox1.Text);
                summ = summ / dl;
                textBox1.Text = summ.ToString();
                deleteTriger = 0;
                multyplyTriger = 1;
                lastAction = "multiply";
                return;
            }
            if (lastAction.Equals("stupen"))
            {
                double stp = double.Parse(textBox1.Text);
                summ = Math.Pow(summ, stp);
                textBox1.Text = summ.ToString();
                stupenTriger = 0;
                multyplyTriger = 1;
                lastAction = "multiply";
                return;
            }
            double number = double.Parse(textBox1.Text);
            summ = summ * number;
            Console.WriteLine(summ);
            textBox1.Text = summ.ToString();
            multyplyTriger = 1;
            lastAction = "multiply";
        }

        private void buttonDeletion_Click(object sender, EventArgs e)
        {
            if (lastAction.Equals(""))
            {
                summ = double.Parse(textBox1.Text);
                deleteTriger = 1;
                lastAction = "deletion";
                return;
            }
            if (lastAction.Equals("pluss"))
            {
                double sbtr = double.Parse(textBox1.Text);
                summ = summ + sbtr;
                textBox1.Text = summ.ToString();
                summTrigger = 0;
                deleteTriger = 1;
                lastAction = "deletion";
                return;
            }
            if (lastAction.Equals("minus"))
            {
                double sbtr = double.Parse(textBox1.Text);
                summ = summ - sbtr;
                textBox1.Text = summ.ToString();
                minusTriger = 0;
                deleteTriger = 1;
                lastAction = "deletion";
                return;
            }
            if (lastAction.Equals("multiply"))
            {
                double mpl = double.Parse(textBox1.Text);
                summ = summ * mpl;
                textBox1.Text = summ.ToString();
                multyplyTriger = 0;
                deleteTriger = 1;
                lastAction = "deletion";
                return;
            }
            if (lastAction.Equals("stupen"))
            {
                double stp = double.Parse(textBox1.Text);
                summ = Math.Pow(summ, stp);
                textBox1.Text = summ.ToString();
                stupenTriger = 0;
                deleteTriger = 1;
                lastAction = "deletion";
                return;
            }
            double number = double.Parse(textBox1.Text);
            if (number == 0)
            {
                lastAction = "";
                textBox1.Text = "Wrong value. Press clear to start again";
                summ = 0;
                return;
            }
            else 
            {
                summ = summ / number;
                Console.WriteLine(summ);
                textBox1.Text = summ.ToString();
                deleteTriger = 1;
                lastAction = "deletion";
            }
        }

        private void buttonStupen_Click(object sender, EventArgs e)
        {
            if (lastAction.Equals(""))
            {
                summ = double.Parse(textBox1.Text);
                deleteTriger = 1;
                lastAction = "stupen";
                return;
            }
            if (lastAction.Equals("pluss"))
            {
                double sbtr = double.Parse(textBox1.Text);
                summ = summ + sbtr;
                Console.WriteLine(summ);
                textBox1.Text = summ.ToString();
                summTrigger = 0;
                stupenTriger = 1;
                lastAction = "stupen";
                return;
            }
            if (lastAction.Equals("minus"))
            {
                double sbtr = double.Parse(textBox1.Text);
                summ = summ - sbtr;
                Console.WriteLine(summ);
                textBox1.Text = summ.ToString();
                minusTriger = 0;
                stupenTriger = 1;
                lastAction = "stupen";
                return;
            }
            if (lastAction.Equals("multiply"))
            {
                double mpl = double.Parse(textBox1.Text);
                summ = summ * mpl;
                Console.WriteLine(summ);
                textBox1.Text = summ.ToString();
                multyplyTriger = 0;
                stupenTriger = 1;
                lastAction = "stupen";
                return;
            }
            if (lastAction.Equals("deletion"))
            {
                double dl = double.Parse(textBox1.Text);
                summ = summ / dl;
                Console.WriteLine(summ);
                textBox1.Text = summ.ToString();
                deleteTriger = 0;
                stupenTriger = 1;
                lastAction = "stupen";
                return;
            }
            double number = double.Parse(textBox1.Text);
            summ = Math.Pow(summ, number);
            Console.WriteLine(summ);
            textBox1.Text = summ.ToString();
            stupenTriger = 1;
            lastAction = "stupen";
        }

        private void buttonSummarize_Click(object sender, EventArgs e)
        {
            if (lastAction.Equals(""))
            {
                summ = double.Parse(textBox1.Text);
                finalTriger = 1;
                lastAction = "";
                return;
            }
            if (lastAction.Equals("pluss"))
            {
                double sbtr = double.Parse(textBox1.Text);
                summ = summ + sbtr;
                Console.WriteLine(summ);
                textBox1.Text = summ.ToString();
                summTrigger = 0;
                finalTriger = 1;
                lastAction = "";
                return;
            }
            if (lastAction.Equals("minus"))
            {
                double sbtr = double.Parse(textBox1.Text);
                summ = summ - sbtr;
                Console.WriteLine(summ);
                textBox1.Text = summ.ToString();
                minusTriger = 0;
                finalTriger = 1;
                lastAction = "";
                return;
            }
            if (lastAction.Equals("multiply"))
            {
                double mpl = double.Parse(textBox1.Text);
                summ = summ * mpl;
                Console.WriteLine(summ);
                textBox1.Text = summ.ToString();
                multyplyTriger = 0;
                finalTriger = 1;
                lastAction = "";
                return;
            }
            if (lastAction.Equals("deletion"))
            {
                double dl = double.Parse(textBox1.Text);
                summ = summ / dl;
                Console.WriteLine(summ);
                textBox1.Text = summ.ToString();
                deleteTriger = 0;
                finalTriger = 1;
                lastAction = "";
                return;
            }
            if (lastAction.Equals("stupen"))
            {
                double stp = double.Parse(textBox1.Text);
                summ = Math.Pow(summ, stp);
                Console.WriteLine(summ);
                textBox1.Text = summ.ToString();
                stupenTriger = 0;
                finalTriger = 1;
                lastAction = "";
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            summ = 0;
            textBox1.Text = summ.ToString();
            lastAction = "";
            return;
        }

        private void negative_Click(object sender, EventArgs e)
        {
            double number = double.Parse(textBox1.Text);
            number = number * -1;
            textBox1.Text = number.ToString();
        }
    }
}

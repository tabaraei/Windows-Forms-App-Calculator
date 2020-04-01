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

        // "result" holds current value in the screen of calculator
        Int64 result = 0;

        // "operation" is used to recognize the '-' or '+' operation
        // to handle the exceptions for sum and sub
        // false is used for sum, true is used for sub
        bool operation = false;

        // "equal" variable is used to know whether user has pressed '=' button or not
        bool equal = false;
        //az equal baraye barresie estefade az operator "=" estefade mishavad
        //chon agar hasele amaliate qabl dar textbox mojud bashad, niazi be afzudane
        //textbox1.Text be result nist ...
        

        // incoming functions are for actions after pressing buttons
        // if a number button is pressed, first it will check whether the value of
        // calculator screen is '0' or not. if its not, it will add the value to screen
        // otherwise it will replace the value

        // if user presses button '1', 1 will be added to the screen of calculator
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
                textBox1.Text += "1";
            else
                textBox1.Text = "1";
        }

        // if user presses button '2', 2 will be added to the screen of calculator
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
                textBox1.Text += "2";
            else
                textBox1.Text = "2";
        }

        // if user presses button '3', 3 will be added to the screen of calculator
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
                textBox1.Text += "3";
            else
                textBox1.Text = "3";
        }

        // if user presses button '4', 4 will be added to the screen of calculator
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
                textBox1.Text += "4";
            else
                textBox1.Text = "4";
        }

        // if user presses button '5', 5 will be added to the screen of calculator
        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
                textBox1.Text += "5";
            else
                textBox1.Text = "5";
        }

        // if user presses button '6', 6 will be added to the screen of calculator
        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
                textBox1.Text += "6";
            else
                textBox1.Text = "6";
        }

        // if user presses button '7', 7 will be added to the screen of calculator
        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
                textBox1.Text += "7";
            else
                textBox1.Text = "7";
        }

        // if user presses button '8', 8 will be added to the screen of calculator
        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
                textBox1.Text += "8";
            else
                textBox1.Text = "8";
        }

        // if user presses button '9', 9 will be added to the screen of calculator
        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
                textBox1.Text += "9";
            else
                textBox1.Text = "9";
        }

        // if user presses button '0', 0 will be added to the screen of calculator
        private void button0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
                textBox1.Text += "0";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            //az in button baraye clear kardan estefade mishavad
            //meqdare pishfarz "0" mibashad

            textBox1.Text = "0";
            result = 0;
            equal = false;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (!equal)
                result += Convert.ToInt64(textBox1.Text);
            else
                equal = false;

            textBox1.Text = "0";
            operation = false; //amade shodan baraye amaliate jam
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (!equal)
                result += Convert.ToInt64(textBox1.Text);
            else
                equal = false;

            textBox1.Text = "0";
            operation = true; //amade shodan baraye amaliate tafriq
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (operation) //tafriq
            {
                result -= Convert.ToInt64(textBox1.Text); ;
                textBox1.Text = (result).ToString();
            }
            else //jam
            {
                result += Convert.ToInt64(textBox1.Text);
                textBox1.Text = (result).ToString();
            }

            equal = true;
        }
    }
}


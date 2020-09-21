using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        double val1, val2;
        string equals;

        private void Form1_Load(object sender, EventArgs e)
        {
            zero();

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            changeLabel(btn.Text);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void changeLabel(string value)
        {

            if(label1.Text.Length < 10)
                label1.Text =  label1.Text == "0" ? label1.Text = value : label1.Text += value;

        }

        public void zero()
        {
            label1.Text = "0";
        }

        private void add(object sender, EventArgs e)
        {
            val1 = Convert.ToDouble(label1.Text);
            equals = "add";
            label2.Text = label1.Text + " + ";
            zero();
        }

        private void subtract(object sender, EventArgs e)
        {
            val1 = Convert.ToDouble(label1.Text);
            equals = "subtract";
            label2.Text = label1.Text + " - ";
            zero();
        }

        private void multiply(object sender, EventArgs e)
        {
            val1 = Convert.ToDouble(label1.Text);
            equals = "multiply";
            label2.Text = label1.Text + " X ";
            zero();
        }

        private void divide(object sender, EventArgs e)
        {
            val1 = Convert.ToDouble(label1.Text);
            equals = "divide";
            label2.Text = label1.Text + " ÷ ";
            zero();
        }

        private void reset(object sender, EventArgs e)
        {
            zero();
            label2.Text = "";
        }

        private void clear(object sender, EventArgs e)
        {
            zero();
        }       

        private void delete(object sender, EventArgs e)
        {
            if (label1.Text != "0" && label1.Text.Length >= 0)
                label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
            else
                zero();
            if (label1.Text == "")
                zero();
        }

        private void percent(object sender, EventArgs e)
        {
            if (label2.Text == "")
                clear(sender, e);
            else
            {

                val2 = Convert.ToDouble(label1.Text);
                label2.Text = label2.Text + val2.ToString() + "%";

                switch (equals)
                {
                    case "add":
                        label1.Text = Convert.ToString(val1 + (val1 * (val2 / 100)));
                        equals = "skip";
                        break;

                    case "subtract":
                        label1.Text = Convert.ToString(val1 - (val1 * (val2 / 100)));
                        equals = "skip";
                        break;
                    case "multiply":
                        label1.Text = Convert.ToString(val1 * (val2 / 100));
                        equals = "skip";
                        break;
                    case "divide":
                        label1.Text = Convert.ToString(val1 / (val2 / 100));
                        equals = "skip";
                        break;
                    default:
                        break;
                }
            }
        }

        private void root(object sender, EventArgs e)
        {
            label2.Text = "√(" + label1.Text + ")";
            label1.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(label1.Text)));
        }

        private void squared(object sender, EventArgs e)
        {
            label2.Text = label1.Text + "²";
            label1.Text = Convert.ToString(Math.Pow(Convert.ToDouble(label1.Text), 2));
        }

        private void onePerX(object sender, EventArgs e)
        {
            label2.Text = "1/" + label1.Text;
            label1.Text = Convert.ToString(1/Convert.ToDouble(label1.Text));
        }

        private void positiveNegative(object sender, EventArgs e)
        {
            if (label1.Text[0] == '-')
                label1.Text = label1.Text.Remove(0, 1);
            else
                if(label1.Text != "0")
                    label1.Text = label1.Text.Insert(0, "-");
        }

        private void dot(object sender, EventArgs e)
        {
            if(!label1.Text.Contains(','))
                label1.Text = label1.Text.Insert(1, ",");
        }

        private void result(object sender, EventArgs e)
        {

            val2 = Convert.ToDouble(label1.Text);
            label2.Text = "";

            switch (equals)
            {
                case "add":
                    label1.Text = Convert.ToString(val1 + val2);
                    equals = "skip";
                    break;
                case "subtract":
                    label1.Text = Convert.ToString(val1 - val2);
                    equals = "skip";
                    break;
                case "multiply":
                    label1.Text = Convert.ToString(val1 * val2);
                    equals = "skip";
                    break;
                case "divide":
                    if (val2 != 0)
                        label1.Text = Convert.ToString(val1 / val2);
                    else
                        label1.Text = "Error, press C";
                    equals = "skip";
                    break;
                case "skip":
                    break;
                default:
                    break;
            }

        }

    }
}
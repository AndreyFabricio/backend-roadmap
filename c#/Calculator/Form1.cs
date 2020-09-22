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
            Zero(); // Inicia a calculadora com 0

        }

        private void Button_Click(object sender, EventArgs e)
        {
            // Função para adcionar os digitos na calculadora

            Button btn = sender as Button;
            // Pega o sender e passa como button para ler seu valor em ChangeLabel
            ChangeLabel(btn.Text);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void ChangeLabel(string value)
        {
            // Adiciona os número digitado na interface da calculadora se digitos < 10
            // Se o digito for 0, apaga o digito e muda para o número digitado
            if(label1.Text.Length < 10)
                label1.Text =  label1.Text == "0" ? label1.Text = value : label1.Text += value;

        }

        public void Zero()
        {
            // Muda o label1 (texto grande na calculadora) para 0
            label1.Text = "0";
        }

        private void Add(object sender, EventArgs e)
        {
            // Função para somar dois valores

            val1 = Convert.ToDouble(label1.Text); // Passa o valor da label1 para uma variável Double
            equals = "Add"; // Sinaliza que ao apertar o botão "=" uma soma será feita
            // Passa o valor de label1 (texto grande) para label2 (texto pequeno acima)
            // O valor passado será acompanhado do símbolo da operação
            label2.Text = label1.Text + " + ";             
            Zero();
        }

        private void Subtract(object sender, EventArgs e)
        {
            // Função para subtrair dois valores
            // Similar a função "Add"
            
            val1 = Convert.ToDouble(label1.Text);
            equals = "Subtract";
            label2.Text = label1.Text + " - ";
            Zero();
        }

        private void Multiply(object sender, EventArgs e)
        {
            val1 = Convert.ToDouble(label1.Text);
            equals = "Multiply";
            label2.Text = label1.Text + " X ";
            Zero();
        }

        private void Divide(object sender, EventArgs e)
        {
            val1 = Convert.ToDouble(label1.Text);
            equals = "Divide";
            label2.Text = label1.Text + " ÷ ";
            Zero();
        }

        private void Reset(object sender, EventArgs e)
        {
            Zero();
            label2.Text = "";
        }

        private void clear(object sender, EventArgs e)
        {
            Zero();
        }       

        private void Delete(object sender, EventArgs e)
        {
            if (label1.Text != "0" && label1.Text.Length >= 0)
                label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
            else
                Zero();
            if (label1.Text == "")
                Zero();
        }

        private void Percent(object sender, EventArgs e)
        {
            if (label2.Text == "")
                clear(sender, e);
            else
            {

                val2 = Convert.ToDouble(label1.Text);
                label2.Text = label2.Text + val2.ToString() + "%";

                switch (equals)
                {
                    case "Add":
                        label1.Text = Convert.ToString(val1 + (val1 * (val2 / 100)));
                        equals = "skip";
                        break;

                    case "Subtract":
                        label1.Text = Convert.ToString(val1 - (val1 * (val2 / 100)));
                        equals = "skip";
                        break;
                    case "Multiply":
                        label1.Text = Convert.ToString(val1 * (val2 / 100));
                        equals = "skip";
                        break;
                    case "Divide":
                        label1.Text = Convert.ToString(val1 / (val2 / 100));
                        equals = "skip";
                        break;
                    default:
                        break;
                }
            }
        }

        private void Root(object sender, EventArgs e)
        {
            label2.Text = "√(" + label1.Text + ")";
            label1.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(label1.Text)));
        }

        private void Squared(object sender, EventArgs e)
        {
            label2.Text = label1.Text + "²";
            label1.Text = Convert.ToString(Math.Pow(Convert.ToDouble(label1.Text), 2));
        }

        private void OnePerX(object sender, EventArgs e)
        {
            label2.Text = "1/" + label1.Text;
            label1.Text = Convert.ToString(1/Convert.ToDouble(label1.Text));
        }

        private void PositiveNegative(object sender, EventArgs e)
        {
            if (label1.Text[0] == '-')
                label1.Text = label1.Text.Remove(0, 1);
            else
                if(label1.Text != "0")
                    label1.Text = label1.Text.Insert(0, "-");
        }

        private void Dot(object sender, EventArgs e)
        {
            if(!label1.Text.Contains(','))
                label1.Text = label1.Text.Insert(1, ",");
        }

        private void Result(object sender, EventArgs e)
        {

            val2 = Convert.ToDouble(label1.Text);
            label2.Text = "";

            switch (equals)
            {
                case "Add":
                    label1.Text = Convert.ToString(val1 + val2);
                    equals = "skip";
                    break;
                case "Subtract":
                    label1.Text = Convert.ToString(val1 - val2);
                    equals = "skip";
                    break;
                case "Multiply":
                    label1.Text = Convert.ToString(val1 * val2);
                    equals = "skip";
                    break;
                case "Divide":
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
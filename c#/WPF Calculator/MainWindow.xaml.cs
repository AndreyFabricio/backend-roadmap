using System;
using System.Windows;
using System.Windows.Controls;

namespace WPF_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double val1, val2;
        string equals;        

        private void ChangeLabel(object sender, RoutedEventArgs e)
        {

            Button btn = sender as Button;
            string lbl = label1.Content.ToString();

            // Adiciona os número digitado na interface da calculadora se digitos < 10
            // Se o digito for 0, apaga o digito e muda para o número digitado

            if (lbl.Length < 10)
                label1.Content = lbl == "0" ? label1.Content = btn.Content : lbl += btn.Content;
        }

        private void PositiveNegative(object sender, RoutedEventArgs e)
        {

            string lbl = label1.Content.ToString();

            if (lbl[0] == '-') label1.Content = lbl.Remove(0, 1);
            else
                if (lbl != "0") label1.Content = lbl.Insert(0, "-");
        }

        private void Dot(object sender, RoutedEventArgs e)
        {
            string lbl = label1.Content.ToString();

            if (!lbl.Contains(','))
            {

                if (lbl[0] != '-')
                {
                    label1.Content =
                        lbl.Length < 2 ? label1.Content.ToString().Insert(1, ",")
                        : label1.Content.ToString().Insert(lbl.Length, ",");
                }
                else
                {
                    label1.Content =
                        lbl.Length < 3 ? label1.Content.ToString().Insert(2, ",")
                        : label1.Content.ToString().Insert(lbl.Length, ",");
                }

            }
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            // Função para somar dois valores

            val1 = Convert.ToDouble(label1.Content); // Passa o valor da label1 para uma variável Double
            equals = "Add"; // Sinaliza que ao apertar o botão "=" uma soma será feita
            // Passa o valor de label1 (texto grande) para label2 (texto pequeno acima)
            // O valor passado será acompanhado do símbolo da operação
            label2.Content = label1.Content + " + ";
            Zero(sender, e);
        }

        private void Subtract(object sender, RoutedEventArgs e)
        {
            val1 = Convert.ToDouble(label1.Content); 
            equals = "Subtract"; 
            label2.Content = label1.Content + " - ";
            Zero(sender, e);
        }

        private void Multiply(object sender, RoutedEventArgs e)
        {
            val1 = Convert.ToDouble(label1.Content);
            equals = "Multiply";
            label2.Content = label1.Content + " X ";
            Zero(sender, e);
        }

        private void Divide(object sender, RoutedEventArgs e)
        {
            val1 = Convert.ToDouble(label1.Content);
            equals = "Divide";
            label2.Content = label1.Content + " ÷ ";
            Zero(sender, e);
        }

        private void Reset(object sender, RoutedEventArgs e)
        {
            Zero(sender, e);
            label2.Content = "";
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            Zero(sender, e);
        }

        private void Delete(object sender, RoutedEventArgs e)
        {

            if (label1.Content.ToString() != "0" && label1.Content.ToString().Length > 0)
                label1.Content = label1.Content.ToString().Substring(0, label1.Content.ToString().Length - 1);
            else
                Zero(sender, e);
            if ((String.IsNullOrEmpty((string)label1.Content)))
                Zero(sender, e);
        }

        private void Zero(object sender, EventArgs e)
        {
            // Muda o label1 (texto grande na calculadora) para 0
            label1.Content = "0";
        }

        private void Result(object sender, RoutedEventArgs e)
        {
            val2 = Convert.ToDouble(label1.Content);
            label2.Content = "";

            switch (equals)
            {
                case "Add":
                    label1.Content = val1 + val2;
                    equals = "skip";
                    break;
                case "Subtract":
                    label1.Content = val1 - val2;
                    equals = "skip";
                    break;
                case "Multiply":
                    label1.Content = val1 * val2;
                    equals = "skip";
                    break;
                case "Divide":
                    if (val2 != 0)
                        label1.Content = val1 / val2;
                    else
                        label1.Content = "Error, press C";
                    equals = "skip";
                    break;
                case "skip":
                    break;
                default:
                    break;
            }
        }

        private void Decimal(object sender, RoutedEventArgs e)
        {
            label2.Content = "1/" + label1.Content;
            label1.Content = 1 / Convert.ToDouble(label1.Content);
        }

        private void Square(object sender, RoutedEventArgs e)
        {
            label2.Content = label1.Content + "²";
            label1.Content = Math.Pow(Convert.ToDouble(label1.Content), 2);
        }

        private void Root(object sender, RoutedEventArgs e)
        {
            label2.Content = "√(" + label1.Content + ")";
            label1.Content = Math.Sqrt(Convert.ToDouble(label1.Content));
        }

        private void Percent(object sender, RoutedEventArgs e)
        {

            string lbl = label2.Content.ToString();


            if (lbl == "")
                Zero(sender, e);
            else
            {

                if (lbl.Length - lbl.Replace("%", "").Length < 1)
                {
                    val2 = Convert.ToDouble(label1.Content);
                    label2.Content = label2.Content + val2.ToString() + "%";
                }
                else
                {
                    equals = "skip";
                }
                
                

                switch (equals)
                {
                    case "Add":
                        label1.Content = val1 + (val1 * (val2 / 100));
                        equals = "skip";
                        break;

                    case "Subtract":
                        label1.Content = val1 - (val1 * (val2 / 100));
                        equals = "skip";
                        break;
                    case "Multiply":
                        label1.Content = val1 * (val2 / 100);
                        equals = "skip";
                        break;
                    case "Divide":
                        label1.Content = val1 / (val2 / 100);
                        equals = "skip";
                        break;
                    default:
                        break;
                }
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}

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

        private void zero()
        {
            // Muda o label1 (texto grande na calculadora) para 0
            label1.ContentStringFormat = "0";
        }

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



        public MainWindow()
        {
            InitializeComponent();
        }
    }
}

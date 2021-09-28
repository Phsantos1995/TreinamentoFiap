using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double n1, n2, resultado;

           n1 = Convert.ToDouble(text1.Text);
           n2 = Convert.ToDouble(text2.Text);

           resultado = n1 + n2;
            ResultadoR.Content = "Soma:"+resultado.ToString();

           



        }

        private void btnsub_Click(object sender, RoutedEventArgs e)
        {
            double n1 = Convert.ToDouble(text1.Text);
            double n2 = Convert.ToDouble(text2.Text);
            double resultado = n1 - n2;

            ResultadoR.Content = "Sub:" + resultado.ToString();
        }

        private void btnmul_Click(object sender, RoutedEventArgs e)
        {
            double n1 = Convert.ToDouble(text1.Text);
            double n2 = Convert.ToDouble(text2.Text);
            double resultado = n1 * n2;

            ResultadoR.Content = "Mult:" + resultado.ToString();







        }

        private void btndivir_Click(object sender, RoutedEventArgs e)
        {
            double n1 = Convert.ToDouble(text1.Text);
            double n2 = Convert.ToDouble(text2.Text);
            double resultado = n1 / n2;

            ResultadoR.Content = "Div:" + resultado.ToString();

        }
    }
}

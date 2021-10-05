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

namespace AlunosNotas
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

        private void btc_Click(object sender, RoutedEventArgs e)
        {
           
            
            string messe;
            double n1 = 0;
            double n2 = 0;
            double n3 = 0;
            
            double media;

            n1 = Convert.ToDouble(txt1.Text);
            n2 = Convert.ToDouble(txt2.Text);
            n3 = Convert.ToDouble(txt3.Text);

            media=n1 + n2 + n3 / 3;

            if (media > 7)
            {
                MessageBox.Show("Aprovado", "", MessageBoxButton.OK, MessageBoxImage.Information); 
            }
            else
            {
                MessageBox.Show("Desprovado", "", MessageBoxButton.OK, MessageBoxImage.Information);
            }
          
         }
    }
}

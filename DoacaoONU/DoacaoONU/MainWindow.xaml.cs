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

namespace DoacaoONU
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

        private void btc_Click(object sender, RoutedEventArgs e)
        {
            double doacao, investimento;
            doacao = Convert.ToInt32(TxtDoacao.Text);

            if (doacao <= 1000)
            {
                investimento = doacao * 0.05;
            }
            else
            {
                investimento = doacao * 0.15;
            }
            MessageBox.Show("O investimento dever ser de r$" + investimento.ToString("0.0"), "ONG", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        
         
            
    }
}

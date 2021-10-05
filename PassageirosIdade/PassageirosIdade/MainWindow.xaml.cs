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

namespace PassageirosIdade
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int  idade;
            string mensagem;
            idade = Convert.ToInt32(TextIDade.Text);

            if (idade<16)
            {
               mensagem= "O passegeiro  nao pode votar e nem embarcar";
            }

            else if (idade > 18)
            {
                 mensagem = "O passegiero é obrigado votar e pode embarcar";
            }

            else{

                mensagem = "Voto obridedwedwedewdwedewdewdew";
            }
            MessageBox.Show(mensagem, "transporte ", MessageBoxButton.OK, MessageBoxImage.Information);
            
        }
    }
}

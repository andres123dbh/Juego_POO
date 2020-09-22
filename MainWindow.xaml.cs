using Juego_POO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.RightsManagement;
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

namespace clases
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dealer a;
        public MainWindow()
        {
            InitializeComponent();
            a = new Dealer();


        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            
            var lista = a.Hand;
            a.Init();
            string showCards;
            showCards = "";
            for(int i = 0 ; i < lista.Count; i++)
            {
                showCards = showCards + "\n" + lista[i].Suit + lista[i].Symbol;
            }
            MessageBox.Show(showCards);

        }
    }
}

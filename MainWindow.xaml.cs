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
        Player gamePlayer;
        public MainWindow()
        {
            InitializeComponent();
            a = new Dealer();
            gamePlayer = new Player();


        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            
            var handDealer = a.Hand;
            a.Init();
            string showCardsDealer;
            showCardsDealer = "";
            for (int i = 0; i < handDealer.Count; i++)
            {
                showCardsDealer = showCardsDealer + "\n" + handDealer[i].Suit + handDealer[i].Symbol;
            }
            MessageBox.Show(showCardsDealer);

            var handPlayer = gamePlayer.Hand;
            gamePlayer.Init(a.Deck);
            string showCardsPlayer;
            showCardsPlayer = "";
            for (int i = 0; i < handPlayer.Count; i++)
            {
                showCardsPlayer = showCardsPlayer + "\n" + handPlayer[i].Suit + handPlayer[i].Symbol;
            }
            MessageBox.Show(showCardsPlayer);
         
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            frameMain.NavigationService.Navigate(new Game());
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}

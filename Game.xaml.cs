using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Juego_POO
{
    /// <summary>
    /// Lógica de interacción para Game.xaml
    /// </summary>
    public partial class Game : Page
    {
        Dealer gameDealer;
        Player gamePlayer;
        public Game()
        {
            InitializeComponent();
            gameDealer = new Dealer();
            gamePlayer = new Player();
            

            
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            btnStart.Visibility = Visibility.Hidden;
            btnHit.Visibility = Visibility.Visible;
            btnStant.Visibility = Visibility.Visible;
            txtHandDealer.Visibility = Visibility.Visible;
            txtHandPlayer.Visibility = Visibility.Visible;
            lblHandDealer.Visibility = Visibility.Visible;
            lblHandPlayer.Visibility = Visibility.Visible;
            txtHandPlayerValue.Visibility = Visibility.Visible;
            lblHandPlayerValue.Visibility = Visibility.Visible;

            StartGame();
          
        }

        private void btnHit_Click(object sender, RoutedEventArgs e)
        {
            string turn = "Player";
            txtHandPlayer.Text = string.Empty;
            txtHandPlayerValue.Text = string.Empty;
            var cardPlayer = gamePlayer.Deal(gameDealer.Deck);
            gamePlayer.AddCard(cardPlayer);
            var handPlayer = gamePlayer.Hand;
            string showCardsPlayer = "";
            for (int i = 0; i < handPlayer.Count; i++)
            {
                showCardsPlayer = showCardsPlayer + "\n" + handPlayer[i].Symbol + handPlayer[i].Suit;
            }
            txtHandPlayer.Inlines.Add(new Run(showCardsPlayer));

            int score = 0;
            for (int i = 0; i < handPlayer.Count; i++)
            {
                score = score + handPlayer[i].Score;
            }
            for (int i = 0; i < handPlayer.Count; i++)
            {
                if (handPlayer[i].Symbol == "A" && score <= 11)
                {
                    score = score + 10;
                }
            }
            txtHandPlayerValue.Inlines.Add(new Run(score.ToString()));

            var handDealer = gameDealer.Hand;
            int scoreDealer = 0;
            for (int i = 0; i < handDealer.Count; i++)
            {
                scoreDealer = scoreDealer + handDealer[i].Score;
            }
            for (int i = 0; i < handDealer.Count; i++)
            {
                if (handDealer[i].Symbol == "A" && scoreDealer <= 11)
                {
                    scoreDealer = scoreDealer + 10;
                }
            }

            Check(score,turn,scoreDealer,0,0);
            

        }

        public int Check(int score , string turn , int scoreDealer , int gamesWin , int gameLose)
        {
            if (turn == "Player")
            {
                var handPlayer = gamePlayer.Hand;
                if (handPlayer.Count == 2)
                {
                    if (score == 21)
                    {
                        MessageBox.Show("You Win");
                        btnHit.Visibility = Visibility.Hidden;
                        btnStant.Visibility = Visibility.Hidden;
                        btnPlayAgain.Visibility = Visibility.Visible;
                        gamesWin = gamesWin + 1;
                        return gamesWin;

                    }
                }
                if (score > 21)
                {
                    MessageBox.Show("You Lose");
                    btnHit.Visibility = Visibility.Hidden;
                    btnStant.Visibility = Visibility.Hidden;
                    btnPlayAgain.Visibility = Visibility.Visible;
                    gameLose = gameLose + 1;
                    return gameLose;
                }
            }
            else
            {
                if (turn == "Dealer")
                {
                    if (scoreDealer > 21)
                    {
                        MessageBox.Show("You Win");
                        gamesWin = gamesWin + 1;
                        return gamesWin;

                    }
                    else
                    {
                        if (scoreDealer > score)
                        {
                            MessageBox.Show("You Lose");
                            gameLose = gameLose + 1;
                            return gameLose;
                        }
                    }
                }
            }
            return 1;
        }

        public void ResetGame()
        {
            gameDealer = new Dealer();
            gamePlayer = new Player();
            txtHandPlayerValue.Text = string.Empty;
            txtHandPlayer.Text = string.Empty;
            txtHandDealer.Text = string.Empty;
            StartGame();
        }

        public void StartGame()
        {
            gameDealer.Init();
            gamePlayer.Init(gameDealer.Deck);

            string turn = "Player";

            var handPlayer = gamePlayer.Hand;
            string showCardsPlayer  = "";
            for (int i = 0; i < handPlayer.Count; i++)
            {
                showCardsPlayer = showCardsPlayer + "\n" + handPlayer[i].Symbol + handPlayer[i].Suit;
            }
            txtHandPlayer.Inlines.Add(new Run(showCardsPlayer));

            string showCardDealer = "\n" + gameDealer.Hand[0].Symbol + gameDealer.Hand[0].Suit;
            txtHandDealer.Inlines.Add(new Run(showCardDealer));
            showCardDealer = "";

            int score = 0;
            for (int i = 0; i < handPlayer.Count; i++)
            {
                score = score + handPlayer[i].Score;
            }
            for (int i = 0; i < handPlayer.Count; i++)
            {
                if (handPlayer[i].Symbol == "A" && score <= 11)
                {
                    score = score + 10;
                }
            }
            txtHandPlayerValue.Inlines.Add(new Run(score.ToString()));
            
            var handDealer = gameDealer.Hand;
            int scoreDealer = 0;
            for (int i = 0; i < handDealer.Count; i++)
            {
                scoreDealer = scoreDealer + handDealer[i].Score;
            }
            for (int i = 0; i < handDealer.Count; i++)
            {
                if (handDealer[i].Symbol == "A" && scoreDealer <= 11)
                {
                    scoreDealer = scoreDealer + 10;
                }
            }

            Check(score, turn, scoreDealer,0,0);
        }


        private void btnStant_Click(object sender, RoutedEventArgs e)
        {
            string turn = "Dealer";
            txtHandDealer.Text = string.Empty;

            var handPlayer = gamePlayer.Hand;
            int scorePlayer = 0;
            for (int i = 0; i < handPlayer.Count; i++)
            {
                scorePlayer = scorePlayer + handPlayer[i].Score;
            }
            for (int i = 0; i < handPlayer.Count; i++)
            {
                if (handPlayer[i].Symbol == "A" && scorePlayer <= 11)
                {
                    scorePlayer = scorePlayer + 10;
                }
            }

            var handDealer = gameDealer.Hand;
            int scoreDealer = 0;
            for (int i = 0; i < handDealer.Count; i++)
            {
                scoreDealer = scoreDealer + handDealer[i].Score;
            }
            for (int i = 0; i < handDealer.Count; i++)
            {
                if (handDealer[i].Symbol == "A" && scoreDealer <= 11)
                {
                    scoreDealer = scoreDealer + 10;
                }
            }

            while (scoreDealer < scorePlayer)
            {
                var cardDealer = gameDealer.Deal();
                gameDealer.AddCard(cardDealer);
                scoreDealer = 0;
                for (int i = 0; i < handDealer.Count; i++)
                {
                    scoreDealer = scoreDealer + handDealer[i].Score;
                }
                for (int i = 0; i < handDealer.Count; i++)
                {
                    if (handDealer[i].Symbol == "A" && scoreDealer <= 11)
                    {
                        scoreDealer = scoreDealer + 10;
                    }
                }

            }

            string showCardsDealer = "";
            for (int i = 0; i < handDealer.Count; i++)
            {
                showCardsDealer = showCardsDealer + "\n" + handDealer[i].Symbol + handDealer[i].Suit;
            }
            txtHandDealer.Inlines.Add(new Run(showCardsDealer));

            Check(scorePlayer, turn, scoreDealer,0,0);
            btnHit.Visibility = Visibility.Hidden;
            btnStant.Visibility = Visibility.Hidden;
            btnPlayAgain.Visibility = Visibility.Visible;
        }

        private void btnPlayAgain_Click(object sender, RoutedEventArgs e)
        {
            btnHit.Visibility = Visibility.Visible;
            btnStant.Visibility = Visibility.Visible;
            btnPlayAgain.Visibility = Visibility.Hidden;
            ResetGame();
        }
    }
}

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
            Gamesgame.gamesWin = 0;
            Gamesgame.gamesLose = 0;

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
            txtGamesLose.Visibility = Visibility.Visible;
            txtGamesWin.Visibility = Visibility.Visible;
            lblGamesLose.Visibility = Visibility.Visible;
            lblGamesWin.Visibility = Visibility.Visible;
            imgGame.Visibility = Visibility.Hidden;

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

            int score = CheckValuePlayerr();
            txtHandPlayerValue.Inlines.Add(new Run(score.ToString()));

            int scoreDealer = CheckValueDealer();

            Check(score, turn, scoreDealer);


        }

        private void btnStant_Click(object sender, RoutedEventArgs e)
        {
            string turn = "Dealer";
            txtHandDealer.Text = string.Empty;

            int scorePlayer = CheckValuePlayerr();

            var handDealer = gameDealer.Hand;
            int scoreDealer = CheckValueDealer();

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

            Check(scorePlayer, turn, scoreDealer);
            PlayAgain();
        }

        private void btnPlayAgain_Click(object sender, RoutedEventArgs e)
        {
            btnHit.Visibility = Visibility.Visible;
            btnStant.Visibility = Visibility.Visible;
            btnPlayAgain.Visibility = Visibility.Hidden;
            ResetGame();
        }

        public int CheckValueDealer()
        {
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
            return scoreDealer;
        }

        public int CheckValuePlayerr()
        {
            var handPlayer = gamePlayer.Hand;
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
            return score;
        }

        public void Check(int score, string turn, int scoreDealer)
        {
            if (turn == "Player")
            {
                var handPlayer = gamePlayer.Hand;
                if (handPlayer.Count == 2)
                {
                    if (score == 21)
                    {
                        MessageBox.Show("You Win");
                        PlayAgain();
                        Gamesgame.gamesWin = Gamesgame.gamesWin + 1;

                    }
                }
                if (score > 21)
                {
                    MessageBox.Show("You Lose");
                    PlayAgain();
                    Gamesgame.gamesLose = Gamesgame.gamesLose + 1;
                }
            }
            else
            {
                if (turn == "Dealer")
                {
                    if (scoreDealer > 21 || scoreDealer == score)
                    {
                        MessageBox.Show("You Win");
                        Gamesgame.gamesWin = Gamesgame.gamesWin + 1;

                    }
                    else
                    {
                        if (scoreDealer > score)
                        {
                            MessageBox.Show("You Lose");
                            Gamesgame.gamesLose = Gamesgame.gamesLose + 1;
                        }
                    }
                }
            }
        }

        public void ResetGame()
        {
            gameDealer = new Dealer();
            gamePlayer = new Player();
            txtHandPlayerValue.Text = string.Empty;
            txtHandPlayer.Text = string.Empty;
            txtHandDealer.Text = string.Empty;
            txtGamesWin.Text = string.Empty;
            txtGamesLose.Text = string.Empty;
            StartGame();
        }

        public void StartGame()
        {
            gameDealer.Init();
            gamePlayer.Init(gameDealer.Deck);

            string turn = "Player";

            var handPlayer = gamePlayer.Hand;
            string showCardsPlayer = "";
            for (int i = 0; i < handPlayer.Count; i++)
            {
                showCardsPlayer = showCardsPlayer + "\n" + handPlayer[i].Symbol + handPlayer[i].Suit;
            }
            txtHandPlayer.Inlines.Add(new Run(showCardsPlayer));

            string showCardDealer = "\n" + gameDealer.Hand[0].Symbol + gameDealer.Hand[0].Suit;
            txtHandDealer.Inlines.Add(new Run(showCardDealer));
            showCardDealer = "";

            int score = CheckValuePlayerr();
            txtHandPlayerValue.Inlines.Add(new Run(score.ToString()));

            int scoreDealer = CheckValueDealer();

            txtGamesWin.Inlines.Add(new Run(Gamesgame.gamesWin.ToString()));
            txtGamesLose.Inlines.Add(new Run(Gamesgame.gamesLose.ToString()));
            Check(score, turn, scoreDealer);
        }

        public void PlayAgain()
        {
            btnHit.Visibility = Visibility.Hidden;
            btnStant.Visibility = Visibility.Hidden;
            btnPlayAgain.Visibility = Visibility.Visible;
        }

        public static class Gamesgame
        {
            public static int gamesWin { get; set; }
            public static int gamesLose { get; set; }
        }
    }
}

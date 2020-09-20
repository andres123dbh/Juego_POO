using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Text;

namespace clases
{
    class Card
    {
        string suit;
        string symbol;
        int score;
        string color;
        
        public Card(string suit, string symbol)
        {
            this.suit = suit;
            this.symbol = symbol;
            if (suit == "♦" || suit == "♥")
            {
                color = "Red";
            }
            else
            {
                if (suit == "♣" || suit == "♠")
                {
                    color = "Black";
                }
            }
            if (symbol == "A")
            {
                score = 1;
            }
            else
            {
                if (symbol == "J" || symbol == "Q" || symbol == "K")
                {
                    score = 10;
                }
                else
                {
                    int valueCard = Convert.ToInt32(symbol);
                    score = valueCard;
                }
            }
        }
        public string Suit
        {
            get { return suit; }
            set { suit = value; }
        }

        public string Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }

        public string ShowIn()
        {
            return "Card: " + symbol + suit + " " + color ;
        }
    }
}

using clases;
using System;
using System.Collections.Generic;
using System.Text;

namespace Juego_POO
{
    class Dealer
    {
        List<Card> deck = new List<Card>();

        List<string> listSuit = new List<string>()
        {
            "♥","♦","♣","♠"
        };
        List<string> listSymbol = new List<string>()
        {
            "A","2","3","4","5","6","7","8","9","J","Q","K"
        };

        public Dealer(){
            Generate();
        }

        public List<Card> Deck
        {
            get { return deck; }
            set { deck = value; }
        }

        public List<string> ListSuit
        {
            get { return listSuit; }
            set { listSuit = value; }
        }

        public List<string> ListSymbol
        {
            get { return listSymbol; }
            set { listSymbol = value; }
        }

        public void Generate()
        {
            for (int i = 0; i < listSuit.Count; i++)
            {
                string suit = listSuit[i];
                for (int a = 0; a < listSymbol.Count; a++)
                {
                    string symbol = listSymbol[a];
                    deck.Add(new Card (suit,symbol));
                }
            }

        }

        

    }
}

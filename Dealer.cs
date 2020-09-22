using clases;
using System;
using System.Collections.Generic;
using System.Resources;
using System.Security.Cryptography;
using System.Text;

namespace Juego_POO
{
    class Dealer
    {
        List<Card> hand = new List<Card>();
        List<Card> deck = new List<Card>();
        List<string> listSuit = new List<string>()
        {
            "♥","♦","♣","♠"
        };
        List<string> listSymbol = new List<string>()
        {
            "A","2","3","4","5","6","7","8","9","10","J","Q","K"
        };

        public Dealer(){
            Generate();
            Randomize();
        }

        public List<Card> Deck
        {
            get { return deck; }
            set { deck = value; }
        }

        public List<Card> Hand
        {
            get { return hand; }
            set { hand = value; }
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

        public void Randomize()
        {
            

            
            List<Card> position = new List<Card>();
            Random numberRandom = new Random();
            for (int i = 0; i < 52; i++)
            {
                var j = numberRandom.Next(0, deck.Count - 1);
                position.Add(deck[j]);
                deck.RemoveAt(j);
            }

            deck = position;


        }

        public List<Card> Deal()
        {
            int b = deck.Count;
            List<Card> lastCard = new List<Card>();
            lastCard.Add(deck[b - 1]);
            deck.RemoveAt(b - 1);
            return lastCard;
        }
        public void AddCard(List<Card> card)
        {
            hand.Add(card[0]);
        }
        public void Init()
        {
            var lastcard = Deal();
            AddCard(lastcard);
            var lastcard2 = Deal();
            AddCard(lastcard2);
        }


    }
}

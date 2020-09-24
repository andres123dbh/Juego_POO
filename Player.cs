using clases;
using System;
using System.Collections.Generic;
using System.Text;

namespace Juego_POO
{
    class Player 
    {
        Dealer a;
        Card b;
        List<Card> hand = new List<Card>();

        public List<Card> Hand
        {
            get { return hand; }
            set { hand = value; }
        }
        public List<Card> Deal(List<Card>  deck)
        {
            a = new Dealer();
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
        public void Init(List<Card> deck)
        {
            var lastcard = Deal(deck);
            AddCard(lastcard);
            var lastcard2 = Deal(deck);
            AddCard(lastcard2);
        }
    }
}

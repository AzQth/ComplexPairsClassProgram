using System;
using System.Collections.Generic;

namespace Complex_Pair_Program
{
    class Card
    {
        protected string name;
        public string Name
        {
            get
            {
                return name;
            }
            protected set
            {
                name = value;
            }
        }

        protected int cost;
        public int Cost
        {
            get
            {
                return cost;
            }
            protected set
            {
                cost = value;
            }
        }

        public Card(string n, int c)
        {
            Name = n;
            Cost = c;
        }

        public static List<Card> Shuffle(List<Card> deck)
        {
            List<Card> currentDeck = new List<Card>();
            currentDeck.AddRange(deck);
            List<Card> shuffledDeck = new List<Card>();
            Random rand = new Random();

            for (int i = 0; i < deck.Count; i++)
            {
                int cardNum = rand.Next(0, currentDeck.Count);
                shuffledDeck.Add(currentDeck[cardNum]);
                currentDeck.RemoveAt(cardNum);
            }

            return shuffledDeck;
        }
    }
}

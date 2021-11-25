using System;
using System.Collections.Generic;

namespace Complex_Pair_Program
{
    internal class Player
    {
        public string name { get; private set; }
        public List<Card> deck { get; set; }
        public List<Card> hand { get; set; }
        public List<Card> discard { get; set; }

        public Player(string name = "")
        {
            this.name = name;
            deck = new List<Card>();
            hand = new List<Card>();
            discard = new List<Card>();
        }

        public void Draw()
        {
            if(deck.Count > 0)
            {
                //Takes a card from deck and puts it into hand.
                hand.Add(deck[0]);
                deck.RemoveAt(0);
            }
            else if(discard.Count > 0)
            {
                //If the deck is empty but discard is not, adds all cards from discard into deck and shuffles,
                //then takes a card from deck and puts it into hand.
                deck.AddRange(discard);
                discard.Clear();

                deck = Card.Shuffle(deck);

                hand.Add(deck[0]);
                deck.RemoveAt(0);
            }
            else
            {
                Console.WriteLine("No cards to draw.");
            }
        }

        public void EndTurn()
        {
            discard.AddRange(hand);
            hand.Clear();

            for(int i = 0; i < 5; i++)
            {
                Draw();
            }
        }
    }
}
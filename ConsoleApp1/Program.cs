using System;
using System.Collections.Generic;

namespace Complex_Pair_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // main program
            Shop.DisplayStock();
            Card testCard = Shop.BuyCard(Input.Input.InputStr("Please, name the card you wish to purchase."));
            // init 
            Player player = new Player(Input.Input.InputStr(prompt: Strings.getName));
            //Random rand = new Random();

            // init player inventory with 7 gold cards of value 1 and 3 point cards of value 1.
            for (int i = 0; i < 10; i++)
            {
                Card card;

                if(i < 7)
                {
                    card = CardPointers.cardClass[CardPointers.EnumerableCards.gold1];
                }
                else
                {
                    card = CardPointers.cardClass[CardPointers.EnumerableCards.points1];
                }

                player.deck.Add(card);
            }

            player.deck = Card.Shuffle(player.deck);

            foreach(Card card in player.deck)
            {
                Console.WriteLine(card.Name);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Complex_Pair_Program
{
    class MilitiaCard:Card
    {
        public MilitiaCard(string n, int c) : base(n, c)
        {

        }

        public static List<Card> Perform(List<Card> hand)
        {
            if(hand.Count <= 3)
            {
                return hand;
            }
            else
            {
                //Displays cards to the user
                Console.WriteLine("Your current hand has more than 3 cards:");
                foreach (Card card in hand)
                {
                    Console.WriteLine(card.Name);
                }

                //Allows user to remove cards
                Console.WriteLine("\nPlease type the name of any cards that you wish to remove. Continue until only 3 cards remain.");

                while (true)
                {
                    string cardToRemove = Console.ReadLine();

                    //Removes a card with the same name as the entered one.

                    bool hasRemoved = false;

                    foreach (Card card in hand)
                    {
                        if (card.Name.ToLower() == cardToRemove.ToLower())
                        {
                            hand.Remove(card);
                            hasRemoved = true;
                            break;
                        }
                    }

                    if (!hasRemoved)
                    {
                        Console.WriteLine("The card you entered is not in your hand.");
                    }

                    if(hand.Count <= 3)
                    {
                        break;
                    }
                }

                //Returns remaining cards
                Console.WriteLine("\nDone! Your remaining cards are:");
                foreach(Card card in hand)
                {
                    Console.WriteLine(card.Name);
                }
                Console.WriteLine();
                return hand;
            }
        }
    }
}

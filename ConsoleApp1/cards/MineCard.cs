using System;
using System.Collections.Generic;
using System.Text;

namespace Complex_Pair_Program
{
    class MineCard:Card
    {
        public MineCard(string n, int c):base(n, c)
        {

        }

        public static List<Card> Perform(List<Card> hand)
        {
            List<GoldCard> goldCards = new List<GoldCard>();

            foreach(Card card in hand)
            {
                if(card is GoldCard)
                {
                    GoldCard gold = (GoldCard)card;
                    if(gold.CardValue == 1 || gold.CardValue == 2)
                    {
                        goldCards.Add(gold);
                    }
                }
            }

            if (goldCards.Count == 0)
            {
                return hand;
            }
            else
            {
                Console.WriteLine("You have these gold cards of values 1 and 2: ");
                foreach (GoldCard gold in goldCards)
                {
                    Console.WriteLine(gold.Name + " of value " + gold.CardValue);
                }
                Console.WriteLine("\nPlease select a card to be replaced by entering its value: ");
                while (true)
                {
                    int cardValue = Convert.ToInt32(Console.ReadLine());

                    bool hasRemoved = false;
                    foreach (GoldCard gold in goldCards)
                    {
                        if (gold.CardValue == cardValue)
                        {
                            hand.Remove(gold);
                            Random rand = new Random();
                            hand.Add(CardCreator.CreateGold(rand.Next(1, 4)));
                            hasRemoved = true;
                            break;
                        }
                    }

                    if (hasRemoved)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The value you entered does not match any cards in your hand. Please try again.");
                    }
                }

                return hand;
            }
        }
    }
}

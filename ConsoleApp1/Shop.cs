using System;
using System.Collections.Generic;
using System.Text;


namespace Complex_Pair_Program
{
    using static CardPointers;

    class Shop
    {
        static int[] stock = new int[15];

        public static void DisplayStock()
        {
            stock[0] = 5;
            for(int i = 0; i < stock.Length; i++)
            {
                Console.WriteLine((EnumerableCards)i + ", " + stock[i] + " remaining.");
            }
        }

        public static Card BuyCard(string cardName)
        {
            for(int i = 0; i < stock.Length; i++)
            {
                if (((EnumerableCards)i).ToString().ToLower() == cardName.ToLower())
                {
                    if(stock[i] > 0)
                    {
                        stock[i]--;
                        return cardClass[(EnumerableCards)i];
                    }
                    else
                    {
                        Console.WriteLine("This card is out of stock.");
                        return null;
                    }
                }
            }

            Console.WriteLine("No such card could be found in our stocks.");
            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Complex_Pair_Program
{
    class CardPointers
    {
        public enum EnumerableCards
        {
            gold1,
            gold2,
            gold3,
            points1,
            points2,
            points3,
        }

        public static Dictionary<EnumerableCards, Card> cardClass = new Dictionary<EnumerableCards, Card>()
        {
            { EnumerableCards.gold1, CardCreator.CreateGold(1)},
            { EnumerableCards.gold2, CardCreator.CreateGold(2)},
            { EnumerableCards.gold3, CardCreator.CreateGold(3)},
            { EnumerableCards.points1, CardCreator.CreatePoint(1)},
            { EnumerableCards.points2, CardCreator.CreatePoint(2)},
            { EnumerableCards.points3, CardCreator.CreatePoint(3)},
        };

    }
}

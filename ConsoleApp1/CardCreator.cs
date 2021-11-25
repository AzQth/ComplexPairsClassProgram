using System;
using System.Collections.Generic;
using System.Text;

namespace Complex_Pair_Program
{
    class CardCreator
    {
        public static GoldCard CreateGold(int value)
        {
            if (value == 1)
            {
                return new GoldCard("gold1", 0, 1);
            }
            else if(value == 2)
            {
                return new GoldCard("gold2", 3, 2);
            }
            else if(value == 3)
            {
                return new GoldCard("gold3", 6, 3);
            }
            else
            {
                throw new Exception("Value needs to be equal to or between 1 and 3");
            }
        }

        public static PointCard CreatePoint(int value)
        {
            if (value == 1)
            {
                return new PointCard("point1", 2, 1);
            }
            else if (value == 2)
            {
                return new PointCard("point2", 5, 2);
            }
            else if (value == 3)
            {
                return new PointCard("point3", 8, 3);
            }
            else
            {
                throw new Exception("Value needs to be equal to or between 1 and 3");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Sevens
{
    class Card 
    {
        private int suit;
        private int pos;
        public Card(int suit, int pos) //test
        {
            this.suit = suit;
            this.pos = pos;
        }
       
        public int getSuit()
        {
            return suit;
        }
        public int getPos()
        {
            return pos;
        }

        public Boolean EqualToSevenOfDiamonds()
        {
            if ((this.suit == 0) && (this.pos == 7))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string suitIntToString() // check letters are in correct order
        {
            if (this.suit == 0)
            {
                return "S";
            }
            else if (this.suit == 1)
            {
                return "H";
            }
            else if (this.suit == 2)
            {
                return "D";
            }
            else
            {
                return "C";
            }
        }

        //public int suitStringToInt(String s)
        //{
        //    if (s == "D")
        //    {
        //        return 0;
        //    }
        //    else if (s == "H")
        //    {
        //        return 1;
        //    }
        //    else if (s == "C")
        //    {
        //        return 2;
        //    }
        //    else
        //    {
        //        return 3;
        //    }
        //}

    }
}

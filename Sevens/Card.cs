using System;
using System.Collections.Generic;
using System.Text;

namespace Sevens
{
    class Card
    {
        private int suit;
        private int pos;
        public Card(int suit, int pos)
        {
            this.suit = suit;
            this.pos =pos;
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
    }
}

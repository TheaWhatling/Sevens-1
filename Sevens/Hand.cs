using System;
using System.Collections.Generic;
using System.Text;

namespace Sevens
{
    class Hand
    {
        private Card[] hand = new Card[13];

        private int cardsstored; //position 

        public Hand()
        {
            cardsstored = 0;
        }

        public void addCardToHand(Card c)
        {
            if (cardsstored < 13)
            {
                hand[cardsstored] = c;
                cardsstored = cardsstored + 1;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Sevens
{
    class Hand
    {
        private Card[] hand = new Card[13];

        private cardsstored = 0;

        addCard(Card c)
        {

        }

        public void addCardToHand(Card c)
        {
            if (cardsstored < 13)
            {
                hand[cardsstored] = c;
            }
        }
    }
}

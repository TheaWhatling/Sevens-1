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

        public int SearchHand(int suit, int card)
        {
            for (int x = 0; x<13; x++)
            {
                if (hand[x] != null)
                {
                    if (hand[x].getSuit() == suit && hand[x].getPos() == 6)
                    {
                        return x;
                    }
                }
            }
            return -1;  // -1 = false
        }

        public Card GetCard(int i)
        {
            return hand[i];
        }

        public void SetCard(Card c , int i)
        {
            hand[i] = c; 
        }
    }
}

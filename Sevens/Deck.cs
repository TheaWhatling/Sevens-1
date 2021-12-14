using System;
using System.Collections.Generic;
using System.Text;

namespace Sevens
{
    class Deck
    {
        private Card[] cards;
        public int FrontPointer;
        public const int decksize = 52;

        public Deck() 
        {
            cards = new Card[decksize];
            FrontPointer = 0;

            int counter = 0;

            for (int CounterSuit = 0; CounterSuit < 4; CounterSuit++)
            {
                for (int valueCounter = 2; valueCounter < 15; valueCounter++)
                {
                    cards[counter] = new Card(valueCounter, CounterSuit);
                    counter++;
                }
            }
        }

        //shuffle
    }
}

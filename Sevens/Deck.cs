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
                for (int PosCounter = 0; PosCounter < 13; PosCounter++)
                {
                    cards[counter] = new Card(CounterSuit, PosCounter);
                    counter++;
                }
            }
        }

        public void Shuffle()
        {
            Card tempo;
            Random random = new Random();

            for (int i = 0; i < decksize; i++)
            {
                int first = random.Next(decksize);
                int second = random.Next(decksize);
                tempo = cards[first];
                cards[first] = cards[second];
                cards[second] = tempo;
            }
            Console.WriteLine(" "); 
        }

    }
}

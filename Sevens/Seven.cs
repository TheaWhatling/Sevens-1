using System;
using System.Collections.Generic;
using System.Text;

namespace Sevens
{
    class Seven
    {
        public Table table;
        public Deck deck;
        private Queue q;

        public Seven()
        {
            table = new Table();
            deck = new Deck();
            q = new Queue(new Player(table), new Player(table), new Player(table), new Player(table));
        }
         
        public Table tab
        {
            get
            {
                return table;
            }
        }

        public void layCard(int x)
        {
            table.Update(new Card(x/13, x % 13));
        }

        public void start()
        {
            deck.Shuffle();

            for (int x = 0; x<52; x = x+1)
            {
                
                q.addCard(deck.GetNextCard());
            }

            for (int y = 0; y < 4; y++)
            {
                q.move();
            }
        }
    }
}
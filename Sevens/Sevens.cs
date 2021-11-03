using System;
using System.Collections.Generic;
using System.Text;

namespace Sevens
{
    class Sevens
    {
        public Table table;

        public Sevens()
        {
            table = new Table();

        }

        public void layCard()
        {
            table.Update(new Card(1, 1));
        }

    }
}

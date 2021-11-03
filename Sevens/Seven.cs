using System;
using System.Collections.Generic;
using System.Text;

namespace Sevens
{
    class Seven
    {
        public Table table;

        public Seven()
        {
            table = new Table();

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

    }
}

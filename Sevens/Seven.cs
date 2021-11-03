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

        public void layCard()
        {
            table.Update(new Card(0, 0));
        }

    }
}

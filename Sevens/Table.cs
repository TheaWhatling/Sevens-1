using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Sevens
{
    class Table
    {
        private ObservableCollection<Position> C = new ObservableCollection<Position>();

        public Table()
        {
            for(int x = 0; x < 52; x = x + 1)
            {
                C.Add(new Position(null));
            }  
        }

        public ObservableCollection<Position> pos
        {
            get
            {
                return C;
            }
        }

        public void Update(Card v)
        {
            if (C[v.getSuit() * 13 + v.getPos()].c == null)
            {
                C[v.getSuit() * 13 + v.getPos()].c = v;
            }
            else
            {
                
            }
        }
        public bool EmptyTable()
        {
            if (C[19] == null)
            {
                return true;
            }
            else return false;
        }
    }
}


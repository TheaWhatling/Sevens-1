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
                //error 
            }
        }
        public bool EmptyTable()
        {
            if (C[19].c == null)
            {
                return true;
            }
            else return false;
        }

        public bool placecard(Card c)
        {
            int index = 0;
            //if 7 return true  
            if (c.getPos() == 6) 
            {
                return true;
            }
            else
            {
                    index = c.getPos() * 13 + c.getSuit();
                    
                    if (c.getPos()> 6 )
                    {
                        if (C[index - 1].c != null)
                        {
                            return true;
                        }
                        else return false;
                    }
                    else
                    {
                        if (C[index + 1].c != null)
                        {
                            return true;
                        }
                        else return false;
                    }
                
               
            }
        }
    }
}
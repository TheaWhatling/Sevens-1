using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Linq;

using System.Threading.Tasks;
using System.Windows.Media;

namespace Sevens
{
    class Position
    {
       
            public event PropertyChangedEventHandler PropertyChanged;

            private Card card;
            public Position(Card x)
            {
                card = x;
            }
            public Card c
            {
                get
                {
                    return card;
                }

                set
                {
                    card = value;
                    OnPropertyChanged("Card");
                }
            }

            void OnPropertyChanged(string propertyName)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }


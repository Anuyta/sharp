using Drinker.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinker
{
    public class Card : IComparable
    {
        private Suit suit;//масть

        public Suit Suit
        {
            get { return suit; }            
        }
        private Value value;

        public Value Value
        {
            get { return this.value; }            
        }

        public Card(Suit suit, Value value)
        {
            this.suit = suit;
            this.value = value;
        }

        public override string ToString()
        {
            return String.Format("{1} of {0}", suit, value);
        }

        public int CompareTo(object obj)
        {
            Card card = (Card)obj;
            if (this.value > card.value && (int)card.value != 6)
                return 1;
            else if (this.value == card.value)
                return 0;
            else
                return -1;            
        }
    }
}

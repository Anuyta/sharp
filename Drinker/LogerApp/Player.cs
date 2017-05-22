using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinker
{
    public class Player
    {
        private string name;

        public string Name
        {
            get { return name; }            
        }
        private List<Card> cards = new List<Card>();

        public List<Card> Cards
        {
            get { return cards; }            
        }

        public Player(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return string.Format("{0}:\n", name, string.Join("\n", cards));
        }
    }
}

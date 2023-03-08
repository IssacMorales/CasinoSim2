using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoSim
{
    public class Cards
    {
        int value;
        string suit;
        private bool ace;

        public bool Ace { get { return ace; } set { ace = value; } }


        public Cards(int value, string suit)
        {
            this.value = value;
            this.suit = suit;

        }

        public int returnValue()
        {
            return value;
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }
}

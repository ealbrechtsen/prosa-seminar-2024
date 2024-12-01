using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Pcg;

namespace DiceWar
{
    public class Dice
    {
        public int Value { get; private set; }

        private static readonly Random rng = new PcgRandom();


        // Sætter Value til et tilfældigt tal mellem 1 og 6 
        public void Roll ()
        {
            Value = rng.Next(1, 7);
        }

        public virtual int Point()
        {
            return Value;
        }

        // Viser værdien som string
        public override string ToString()
        {
            return $"[{Value}]";
        }
    }
}

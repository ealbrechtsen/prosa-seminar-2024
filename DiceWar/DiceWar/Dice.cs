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

        public void Roll ()
        {
            Value = rng.Next(1, 7);
        }

        public virtual int Point()
        {
            return Value;
        }

        public override string ToString()
        {
            return $"[{Value}]";
        }
    }
}

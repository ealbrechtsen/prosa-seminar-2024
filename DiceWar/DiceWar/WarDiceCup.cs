using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceWar
{
    public class WarDiceCup
    {
        private WarDice[] _diceArray;

        public WarDiceCup(int numberOfDices)
        {
            _diceArray = new WarDice[numberOfDices];
            for (int i = 0; i < numberOfDices; i++)
            {
                _diceArray[i] = new WarDice();
            }
        }

        public void RollAll()
        {
            foreach (var dice in _diceArray)
            {
                dice.Roll();
            }
        }

        public int Point()
        {
            int sum = 0;
            foreach (var dice in _diceArray)
            {
                sum += dice.Point();
            }
            return sum;
        }



    }
}

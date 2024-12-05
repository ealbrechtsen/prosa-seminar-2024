using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceWar
{
    public class Game
    {
        private WarDiceCup _playerCup;
        private WarDiceCup _computerCup;
        private int _playerPoint;
        private int _computerPoint;
        private int _rounds;

        public Game(int numberOfDices, int rounds)
        {
            _playerCup = new WarDiceCup(numberOfDices);
            _computerCup = new WarDiceCup(numberOfDices);
            _rounds = rounds;
        }

        public void PlayRound()
        {
            _playerCup.RollAll();
            _computerCup.RollAll();

            _playerPoint += _playerCup.Point();
            _computerPoint += _computerCup.Point();

            Console.WriteLine($"Player rolled:   {_playerCup} with total of: {_playerCup.Point().ToString()}");
            Console.WriteLine($"Computer rolled: {_computerCup} with total of: {_computerCup.Point().ToString()}");
            
            _rounds--;
        }

        public void StartGame()
        {
            for (int i = 1; i <= _rounds; i++)
            {
                Console.WriteLine($"\nRound {i}");
                PlayRound();
            }
            Console.WriteLine("\nEnd results:\n");
            Console.WriteLine($"Player total points:   {_playerPoint}");
            Console.WriteLine($"Computer total points: {_computerPoint}");
        }
    }
}

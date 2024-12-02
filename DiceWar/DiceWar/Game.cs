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

            int playerRoundPoints = _playerCup.Point();
            int computerRoundPoints = _computerCup.Point();

            _playerPoint += playerRoundPoints;
            _computerPoint += computerRoundPoints;

            Console.WriteLine($"Player rolled: {_playerCup}");
            Console.WriteLine($"Computer rolled: {_computerCup}");
            Console.WriteLine($"Player points this round: {playerRoundPoints}");
            Console.WriteLine($"Computer points this round: {computerRoundPoints}");
            Console.WriteLine($"Total player points: {_playerPoint}");
            Console.WriteLine($"Total computer points: {_computerPoint}");

            _rounds--;
        }

        public void StartGame(int numberOfDices, int rounds)
        {
            for (int i = 1; i <= rounds; i++)
            {
                Console.WriteLine($"\nRound {i}");
                PlayRound();
            }
            Console.WriteLine("\nGame over!");
            Console.WriteLine($"Player total points: {_playerPoint}");
            Console.WriteLine($"Computer total points: {_computerPoint}");
        }
    }
}

namespace DiceWar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Dice War!");
            Console.WriteLine("Press any key to start the game...");
            Console.ReadKey();

            Game g = new Game(5, 10);
            g.StartGame();

            Console.ReadKey();
        }
    }
}

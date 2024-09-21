using System;
namespace _1_guess_a_number_iterative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Random number between 0 and 100
            Random random = new();
            int numberToGuess = random.Next(1, 101);

            Console.WriteLine("Der er genereret et random tal mellem 1 og 100, gæt det!");
            int userGuess = 0;

            while (userGuess != numberToGuess)
            {
                Console.WriteLine("Dit svar: ");
                string? input = Console.ReadLine();

                userGuess = Convert.ToInt32(input);
                Console.Clear();

                if (userGuess >= numberToGuess)
                {
                    Console.WriteLine("Gæt igen! men mindre!");
                }
                else if (userGuess <= numberToGuess)
                {
                    Console.WriteLine("Gæt igen! denne gang højere!");
                }

            }
            Console.Clear();
            Console.WriteLine("Tillykke du gættede rigtigt!");
            Console.WriteLine("Det rigtige svar var " + numberToGuess);
            Console.ReadKey();
            //
        }
    }
}

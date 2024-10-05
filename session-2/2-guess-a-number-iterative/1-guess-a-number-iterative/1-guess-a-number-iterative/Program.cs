using System;
namespace _1_guess_a_number_iterative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dette er spillet hvor du skal gætte et tal! Indtast det maksimale tal du vil kunne gætte!");
            int inputMaximum = Convert.ToInt32(Console.ReadLine());

            Random random = new();
        
            int numberToGuess = random.Next(1, inputMaximum);

            int attempts = 0;

            int userGuess = 0;

            while (userGuess != numberToGuess)
            {
                Console.WriteLine("Dit svar: ");
                string? input = Console.ReadLine();

                userGuess = Convert.ToInt32(input);
                Console.Clear();

                attempts++;

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
            Console.WriteLine($"Det rigtige svar var {numberToGuess} efter {attempts} forsøg");
            Console.ReadKey();
            //
        }
    }
}

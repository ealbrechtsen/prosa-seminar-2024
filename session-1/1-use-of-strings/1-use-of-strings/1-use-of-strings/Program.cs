namespace _1_use_of_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Mikkel";
            string lastName = "Cronberg";
            string nameString = firstName + lastName;
            Console.WriteLine($"{nameString.ToUpper()}");
        }
    }
};

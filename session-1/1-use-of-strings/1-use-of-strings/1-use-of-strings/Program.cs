namespace _1_use_of_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Mikkel";
            string lastName = "Cronberg";
            string nameString = firstName + " " +lastName;
            
            string uppercaseName = nameString.ToUpper();
            Console.WriteLine(uppercaseName);

            string lowercaseName = nameString.ToLower();
            Console.WriteLine(lowercaseName);

            string subString = nameString.Substring(7, 4);
            Console.WriteLine(subString);
            Console.WriteLine(firstName + "\r\n\t" + lastName);
        }
    }
};

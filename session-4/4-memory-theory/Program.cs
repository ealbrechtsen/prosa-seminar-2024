using _4_memory_theory;
using System;


internal class Program
{
    private static void Main(string[] args)
    {

        Person k1 = new Person();
        k1.Id = 1;
        Person k2 = new Person();
        k2.Id = 2;
        Console.WriteLine(k1.Id);
        Console.WriteLine(k2.Id);
        k1 = k2;
        Console.WriteLine(k1.Id);
        Console.WriteLine(k2.Id);
        k1.Id = 3;
        Console.WriteLine(k1.Id);
        Console.WriteLine(k2.Id);
    }
}
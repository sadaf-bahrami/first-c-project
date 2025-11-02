using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.Write( "enter your name:");
        string name = Console.ReadLine();
        Console.Write("enter your family:");
        string family = Console.ReadLine();
        Console.WriteLine($"my name is {name} & my family is {family}.");
        Console.ReadKey();

    }
}

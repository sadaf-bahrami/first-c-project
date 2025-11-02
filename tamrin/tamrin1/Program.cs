using System;
internal class tamrin
{
    static void Main(string[] args)
    {
        Console.Write("enter your number:");
        double inch = Convert.ToInt32(Console.ReadLine());
        double cm = inch * 2.54;
        Console.WriteLine($"{inch} inch & {cm} cm.");
        Console.ReadKey();
    }
}

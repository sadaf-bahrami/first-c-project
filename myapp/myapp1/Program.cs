using System;
internal class myapp
{
    static void Main(string[] args)
    {
        Console.Write(" enter your number: ");
        int a = Convert.ToInt32 (Console.ReadLine());
        int mohit = 4 * a;
        int masahat = a * a;
        Console.WriteLine($"mohit is {mohit} and masahat is {masahat}.");
        Console.ReadKey();
    }
    
}

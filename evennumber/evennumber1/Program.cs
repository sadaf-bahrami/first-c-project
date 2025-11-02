using System;
internal class Evennumber
{
    static void Main(string[] args)
    {
        Console.Write("enter your number: ");
        int a = Convert.ToInt32 (Console.ReadLine());
        if(a % 2 == 0)
        {
            Console.WriteLine($"{a} is even number");
        }
        else
        {
            Console.WriteLine($"{a} is odd number");   
        }
        Console.ReadKey();
    }
}


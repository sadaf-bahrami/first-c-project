using System;
internal class mazrab7
{
    static void Main(string[] args)
    {
        Console.Write("enter your number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int result;
        if (a%7==0)
        {
            Console.WriteLine("YES!");
        }
        else
        {
            result = a*3;
            Console.WriteLine($"{result}");
        }
    }
}
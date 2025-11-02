using System;
internal class maxmin
{
    static void Main(string[] args)
    {
        Console.Write("enter your first number: ");
        int a = Convert.ToInt32(Console.ReadLine());
         Console.Write("enter your second number: ");
        int b = Convert.ToInt32(Console.ReadLine());
         Console.Write("enter your third number: ");
        int c = Convert.ToInt32(Console.ReadLine());
        int max, min;
        if(a>=b && a>=c)
        {
            max = a;
        }
        else if(b>=a && b>=c)
        {
            max = b;
        }
        else
        {
            max = c;
        }
        if(a<=b && a<=c)
        {
            min = a;
        }
        else if(b<=a && b<=c)
        {
            min = b;
        }
        else
        {
            min = c;
        }
        Console.WriteLine($"max is {max}");
        Console.WriteLine($"min is {min}");
        Console.ReadKey();
    }
}
using System;
internal class trueprint
{
    static void Main(string[] args)
    {
        Console.Write("enter your number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        if(a < 10 && a % 2 == 0)
        {
            Console.WriteLine("TRUE");
        }
        else
        {
            Console.WriteLine("FALSE");           
        }
    }
}
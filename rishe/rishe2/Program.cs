using System;
internal class rishe
{
    static void Main(string[] args)
    {
        Console.Write("enter your first number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("enter your second number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("enter your third number: ");
        int c = Convert.ToInt32(Console.ReadLine());
        if(b*b-4*a*c>=0)
        {
            Console.WriteLine($"it has rishe");
        }
        else
        {
            Console.WriteLine($"it hasn't a rishe");
        }
    }
    
}

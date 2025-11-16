using System;
internal class sumshow
{
    static void Main(string[]args)
    {
        /*do
            {
                Console.Write("Enter a number: ");
                a = Int32.Parse(Console.ReadLine());
                sum += a;
            } while (a != 0);*/   
        Console.Write("enter number: ");
        int a = Int32.Parse(Console.ReadLine());
        int sum = 0;
        while (a != 0)
        {
            sum += a;
            Console.Write("enter number: ");
            a = Int32.Parse(Console.ReadLine());
        }
        Console.WriteLine($"sum = " + sum);
        Console.ReadKey();
    }
}

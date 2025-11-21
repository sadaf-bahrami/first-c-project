using System;
internal class zarb
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter your number: ");
            int a = Int32.Parse(Console.ReadLine());
            int result = 1;
            while (a!=0)
            {
                result *= a;
                Console.Write("enter your number: ");
                a = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine($"result = " + result);
            Console.ReadKey();
        }
    }

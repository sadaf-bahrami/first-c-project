using System;
namespace starharf
{
    internal class starharf1
    {
        static void Main(string[] args)
        {
            PrintE();
            Console.WriteLine();
            PrintH();
            Console.WriteLine();
            PrintI();
        }
        static void PrintE()
        {
            Console.WriteLine("*******");
            Console.WriteLine("*");
            Console.WriteLine("*");
            Console.WriteLine("*****");
            Console.WriteLine("*");
            Console.WriteLine("*");
            Console.WriteLine("*******");
        }
        static void PrintH()
        {
            Console.WriteLine("*     *");
            Console.WriteLine("*     *");
            Console.WriteLine("*     *");
            Console.WriteLine("*******");
            Console.WriteLine("*     *");
            Console.WriteLine("*     *");
            Console.WriteLine("*     *");
        }

        static void PrintI()
        {
            Console.WriteLine("*******");
            Console.WriteLine("   *   ");
            Console.WriteLine("   *   ");
            Console.WriteLine("   *   ");
            Console.WriteLine("   *   ");
            Console.WriteLine("   *   ");
            Console.WriteLine("*******");
        }
        /*    static void PrintE()
    {
        int rows = 5;
        int cols = 5;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (i == 0 || i == 2 || i == rows - 1 || j == 0)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }

    static void PrintH()
    {
        int rows = 5;
        int cols = 5;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (j == 0 || j == cols - 1 || i == 2)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }*/
    }
}

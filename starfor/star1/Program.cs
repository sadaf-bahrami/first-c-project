using System;
internal class starfor
{
    static void Main(string[]args)
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
         /*for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.WriteLine("*");
            }
            Console.WriteLine("");
        }*/
        Console.ReadKey();
    }
}

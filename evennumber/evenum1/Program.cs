using System;
internal class evennumber
{
    static void Main(string[]args)
    {
        int limit = 99;
        for (int i = 10; i <= limit; i += 2)
        {
            Console.WriteLine($"{i} is even number");
        }

            /*for(int i = 10; i < 100; i++)
            {
                if (i % 2 == 0)
                Console.WriteLine(i);
            }*/

            /*for (int i = 10; i < 100; i += 2)
            {
                Console.WriteLine(i);
            }*/
        Console.ReadKey();
    }
}

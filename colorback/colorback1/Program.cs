using System;
namespace SwitchBackground
{
    internal class BackgroundColor1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number: ");
            int a = Int32.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                     Console.BackgroundColor=ConsoleColor.Red;
                     Console.Clear();
                     break;
                 case 2:
                     Console.BackgroundColor=ConsoleColor.Blue;
                     Console.Clear();
                     break;
                 default: 
                     Console.BackgroundColor=ConsoleColor.Yellow;
                     Console.Clear();
                     break;
            }
        }
    }
}
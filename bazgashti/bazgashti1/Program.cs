
using System;

internal class bazgashti
{
    // Recursive function to multiply two numbers
    static int RecursiveMultiply(int a, int b)
    {
        // Base case
        if (b == 0)
            return 0;

        // Handle negative values of b
        if (b < 0)
            return -RecursiveMultiply(a, -b);

        // Recursive call
        return a + RecursiveMultiply(a, b - 1);
    }

    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());

        int result = RecursiveMultiply(num1, num2);

        Console.WriteLine($"The product of {num1} and {num2} is: {result}");
    }
}

using System;

class Program
{
    static void Main()
    {
        Console.Write("دمای سانتی‌گراد را وارد کنید: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine($"{celsius} درجه سانتی‌گراد برابر است با {fahrenheit} درجه فارنهایت.");
    }
}


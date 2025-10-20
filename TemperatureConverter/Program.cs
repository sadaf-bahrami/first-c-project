using System;

class Program
{
    static void Main()
    {
        Console.Write("شعاع دایره را وارد کنید: ");
        double r = Convert.ToDouble(Console.ReadLine());

        double mohit = 2 * Math.PI * r;
        double masahat = Math.PI * r * r;

        Console.WriteLine($"محیط دایره: {mohit}");
        Console.WriteLine($"مساحت دایره: {masahat}");
    }
}
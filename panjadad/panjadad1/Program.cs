using System;
internal class panjadad
{
    static void Main()
    {
        int[] nums = new int[5];
        bool found = false;
        int position = -1;
        Console.WriteLine("Enter 5 numbers:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Number " + (i + 1) + ": ");
            nums[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < 5; i++)
        {
            if (nums[i] == 2)
            {
                found = true;
                position = i + 1;
                break;
            }
        }
        if (found)
            Console.WriteLine("Number 2 exists and it is number " + position + " in the list.");
        else
            Console.WriteLine("Number 2 does NOT exist in the list.");
    }
}

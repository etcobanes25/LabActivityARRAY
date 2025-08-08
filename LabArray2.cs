using System;

public class Program
{
    public static void Main()
    {
        string[] fruits = new string[5];
        int appleCount = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter favorite fruit #" + (i + 1) + ": ");
            string input = Console.ReadLine().ToLower();
            fruits[i] = input;

            if (input == "apple")
            {
                appleCount++;
            }
        }

        Console.WriteLine("\nYou entered 'apple' {0} time(s).", appleCount);
    }
}
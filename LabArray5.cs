using System;

public class Program
{
    public static void Main()
    {
        int[] numbers = new int[10];
        int evenCount = 0;
        int oddCount = 0;
        int divisibleBy5Count = 0;

        // Input values
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Enter number #{i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Analyze values
        foreach (int num in numbers)
        {
            if (num % 2 == 0)
                evenCount++;
            else
                oddCount++;

            if (num % 5 == 0)
                divisibleBy5Count++;
        }

        // Output results
        Console.WriteLine("\n--- Result ---");
        Console.WriteLine("Even numbers: " + evenCount);
        Console.WriteLine("Odd numbers: " + oddCount);
        Console.WriteLine("Divisible by 5: " + divisibleBy5Count);
    }
}
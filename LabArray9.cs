using System;

public class Program
{
    public static void Main()
    {
        int[] numbers = new int[3];

        // Input
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Enter number #{i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Output tables
        Console.WriteLine("\n--- Multiplication Tables ---\n");

        foreach (int num in numbers)
        {
            Console.WriteLine($"Multiplication Table for {num}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
            Console.WriteLine();
        }
    }
}
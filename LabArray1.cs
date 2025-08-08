using System;

public class Program
{
    public static void Main()
    {
        int[] ages = new int[5];
        int count = 0;

        while (count < 5)
        {
            Console.Write("Enter age for customer " + (count + 1) + ": ");
            int age = int.Parse(Console.ReadLine());

            if (age >= 10 && age <= 99)
            {
                ages[count] = age;
                count++;
            }
            else
            {
                Console.WriteLine("Invalid age. Must be between 10 and 99.");
            }
        }

        int teenCount = 0;
        Console.WriteLine("\nValid ages entered:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Customer {i + 1}: {ages[i]}");
            if (ages[i] >= 13 && ages[i] <= 19)
            {
                teenCount++;
            }
        }

        Console.WriteLine($"\nNumber of teenagers: {teenCount}");
    }
}

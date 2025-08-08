using System;

public class Program
{
    public static void Main()
    {
        float[] heights = new float[6];
        int shortCount = 0, averageCount = 0, tallCount = 0;

        // Input
        for (int i = 0; i < heights.Length; i++)
        {
            Console.Write($"Enter height #{i + 1} in cm: ");
            heights[i] = Convert.ToSingle(Console.ReadLine());
        }

        // Classification
        Console.WriteLine("\n--- Height Classification ---\n");

        for (int i = 0; i < heights.Length; i++)
        {
            float h = heights[i];
            Console.Write($"Person #{i + 1} with height {h} cm is ");

            if (h < 150)
            {
                Console.WriteLine("Short");
                shortCount++;
            }
            else if (h <= 170)
            {
                Console.WriteLine("Average");
                averageCount++;
            }
            else
            {
                Console.WriteLine("Tall");
                tallCount++;
            }
        }

        // Totals
        Console.WriteLine($"\nTotal Short: {shortCount}");
        Console.WriteLine($"Total Average: {averageCount}");
        Console.WriteLine($"Total Tall:    {tallCount}");
    }
}
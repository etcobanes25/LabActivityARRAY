using System;

public class Program
{
    public static void Main()
    {
        float[] sales = new float[12];
        string[] months = { "January", "February", "March", "April", "May", "June",
                            "July", "August", "September", "October", "November", "December" };

        // Input sales data
        for (int i = 0; i < 12; i++)
        {
            Console.Write($"Enter sales for {months[i]}: ");
            while (!float.TryParse(Console.ReadLine(), out sales[i]) || sales[i] < 0)
            {
                Console.WriteLine("Invalid input. Enter a non-negative number.");
                Console.Write($"Enter sales for {months[i]}: ");
            }
        }

        // Initialize for tracking
        int highestIndex = 0;
        int lowestIndex = 0;
        float total = 0;

        // Analyze data
        for (int i = 0; i < 12; i++)
        {
            if (sales[i] > sales[highestIndex])
                highestIndex = i;
            if (sales[i] < sales[lowestIndex])
                lowestIndex = i;

            total += sales[i];
        }

        float average = total / 12;

        // Display results
        Console.WriteLine("\n--- Sales Report ---");
        Console.WriteLine($"Highest Sales: {months[highestIndex]} - {sales[highestIndex]:F2}");
        Console.WriteLine($"Lowest Sales: {months[lowestIndex]} - {sales[lowestIndex]:F2}");
        Console.WriteLine($"Average Sales: {average:F2}");
    }
}
using System;
class Program
{
    static void Main()
    {
        string[] categories = { "Food", "Rent", "Utilities", "Transport", "Others" };
        int[] budgets = new int[5];
        int total = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter budget for {0}: ₱", categories[i]);
            budgets[i] = int.Parse(Console.ReadLine());
            total += budgets[i];
        }

        Console.WriteLine("\nTotal Budget: ₱" + total);

        if (total > 25000)
        {
            int max = budgets[0];
            int maxIndex = 0;

            for (int i = 1; i < 5; i++)
            {
                if (budgets[i] > max)
                {
                    max = budgets[i];
                    maxIndex = i;
                }
            }

            Console.WriteLine("Over budget. Consider reducing: " + categories[maxIndex]);
        }
        else
        {
            Console.WriteLine("Budget is within the limit.");
        }
    }
}
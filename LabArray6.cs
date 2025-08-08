using System;

public class Program
{
    public static void Main()
    {
        double[] celsiusTemps = new double[5];

        // Input temperatures
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Enter temperature #{i + 1} in Celsius: ");
            celsiusTemps[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("\n--- Temperature Report ---");
        Console.WriteLine("Celsius\tFahrenheit\tCategory");

        // Conversion and classification
        foreach (double c in celsiusTemps)
        {
            double f = c * 9 / 5 + 32;
            string category;

            if (c < 15)
                category = "Cold";
            else if (c <= 30)
                category = "Warm";
            else
                category = "Hot";

            Console.WriteLine($"{c}\t{f:F1}\t\t{category}");
        }
    }
}
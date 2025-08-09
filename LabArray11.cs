using System;

public class Program
{
    public static void Main()
    {
        string[] names = new string[10];
        int[] ages = new int[10];

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"\nCitizen #{i + 1}");

            // Input name
            Console.Write("Enter name: ");
            names[i] = Console.ReadLine();

            // Input and validate age
            int age;
            while (true)
            {
                Console.Write("Enter age: ");
                if (int.TryParse(Console.ReadLine(), out age) && age >= 0 && age <= 120)
                {
                    ages[i] = age;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid age. Please enter a value between 0 and 120.");
                }
            }
        }

        // Output results
        Console.WriteLine("\n--- Voter Eligibility & Category ---\n");
        for (int i = 0; i < 10; i++)
        {
            string category = "Not Eligible to Vote";

            if (ages[i] >= 18)
            {
                if (ages[i] <= 30)
                    category = "Young Voter";
                else if (ages[i] <= 59)
                    category = "Mid-age Voter";
                else
                    category = "Senior Voter";
            }

            Console.WriteLine($"Name: {names[i]}, Age: {ages[i]}, Category: {category}");
        }
    }
}
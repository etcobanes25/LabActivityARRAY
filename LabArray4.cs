using System;

public class Program
{
    public static void Main()
    {
        string[] names = new string[3];

        // Input names
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter name #{i + 1}: ");
            names[i] = Console.ReadLine();
        }

        Console.WriteLine("\n--- Character Access Result ---");
        for (int i = 0; i < 3; i++)
        {
            string name = names[i];
            char firstChar = name[0];
            char lastChar = name[name.Length - 1];
            string upperName = name.ToUpper();

            Console.WriteLine($"Original Name: {name}");
            Console.WriteLine($"First Character: {firstChar}");
            Console.WriteLine($"Last Character: {lastChar}");
            Console.WriteLine($"Uppercase Version: {upperName}");
            Console.WriteLine();
        }
    }
}
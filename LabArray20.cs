using System;

class Program
{
    static void Main()
    {
        string[] words = new string[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter word {0}: ", i + 1);
            words[i] = Console.ReadLine();
        }

        Console.WriteLine("\nPalindrome Check Results:\n");

        for (int i = 0; i < 5; i++)
        {
            string original = words[i];
            string reversed = "";

            for (int j = original.Length - 1; j >= 0; j--)
            {
                reversed += original[j];
            }

            if (original.ToLower() == reversed.ToLower())
            {
                Console.WriteLine("Word {0}: Palindrome", i + 1);
            }
            else
            {
                Console.WriteLine("Word {0}: Not a Palindrome", i + 1);
            }
        }
    }
}
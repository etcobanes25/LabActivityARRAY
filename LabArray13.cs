using System;

class Program
{
    static void Main()
    {
        string[] emails = new string[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter email address #{0}: ", i + 1);
            emails[i] = Console.ReadLine();
        }

        Console.WriteLine("\n--- Validation Result ---");

        for (int i = 0; i < 5; i++)
        {
            string email = emails[i];

            // Check if email contains '@' and ends with .com or .edu
            if (email.Contains("@") &&
                (email.EndsWith(".com") || email.EndsWith(".edu")))
            {
                int atIndex = email.IndexOf('@');
                string username = email.Substring(0, atIndex);
                Console.WriteLine("Valid: {0} | Username: {1}", email, username);
            }
            else
            {
                Console.WriteLine("Invalid: {0}", email);
            }
        }
    }
}
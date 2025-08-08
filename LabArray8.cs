using System;

public class Program
{
    public static void Main()
    {
        string[] passwords = new string[4];

        for (int i = 0; i < passwords.Length; i++)
        {
            Console.Write($"Enter password #{i + 1}: ");
            passwords[i] = Console.ReadLine();
        }

        Console.WriteLine("\n--- Password Validation Results ---");

        foreach (string password in passwords)
        {
            bool isValid = true;

            if (password.Length < 6)
            {
                isValid = false;
            }

            bool hasUpper = false;
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    hasUpper = true;
                    break;
                }
            }

            if (!hasUpper)
            {
                isValid = false;
            }

            Console.WriteLine($"{password} - {(isValid ? "Valid" : "Invalid")}");
        }
    }
}
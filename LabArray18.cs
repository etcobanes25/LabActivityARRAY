using System;

class Program
{
    static void Main()
    {
        string[] passwords = new string[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter password {0}: ", i + 1);
            passwords[i] = Console.ReadLine();
        }

        Console.WriteLine("\nPassword Strength Results:\n");

        for (int i = 0; i < 5; i++)
        {
            string password = passwords[i];
            int score = 0;

            // Check 1: Length
            if (password.Length >= 8)
                score++;

            // Check 2: Uppercase letter
            bool hasUpper = false;
            bool hasDigit = false;
            bool hasSpecial = false;

            foreach (char ch in password)
            {
                if (char.IsUpper(ch)) hasUpper = true;
                if (char.IsDigit(ch)) hasDigit = true;
                if ("!@#$%^&*()_+=-{}[]:;'<>,.?/\\|".Contains(ch)) hasSpecial = true;
            }

            if (hasUpper) score++;
            if (hasDigit) score++;
            if (hasSpecial) score++;

            // Classification
            string strength = "";
            if (score == 4)
                strength = "Strong";
            else if (score >= 2)
                strength = "Weak";
            else
                strength = "Invalid";

            Console.WriteLine("Password {0}: {1}", i + 1, strength);
        }
    }
}
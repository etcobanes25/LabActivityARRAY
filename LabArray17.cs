using System;
class Program
{
    static void Main()
    {
        int[] numbers = new int[8];

        for (int i = 0; i < 8; i++)
        {
            Console.Write("Enter whole number {0}: ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nNumber Classification:\n");

        for (int i = 0; i < 8; i++)
        {
            int num = numbers[i];
            bool isPrime = IsPrime(num);
            string binary = Convert.ToString(num, 2);
            string evenOdd = (num % 2 == 0) ? "Even" : "Odd";

            Console.WriteLine("Number {0}:", num);
            Console.WriteLine(" - Prime: {0}", isPrime ? "Yes" : "No");
            Console.WriteLine(" - Binary: {0}", binary);
            Console.WriteLine(" - {0}\n", evenOdd);
        }
    }

    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        for (int i = 2; i <= number / 2; i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
}
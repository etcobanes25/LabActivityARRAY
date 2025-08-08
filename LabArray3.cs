using System;

public class Program
{
    public static void Main()
    {
        float[] scores = new float[5];
        char[] grades = new char[5];

        for (int i = 0; i < scores.Length; i++)
        {
            Console.Write($"Enter score {i + 1}: ");
            scores[i] = float.Parse(Console.ReadLine());

            if (scores[i] >= 90)
                grades[i] = 'A';
            else if (scores[i] >= 80)
                grades[i] = 'B';
            else if (scores[i] >= 70)
                grades[i] = 'C';
            else if (scores[i] >= 60)
                grades[i] = 'D';
            else
                grades[i] = 'F';
        }

        Console.WriteLine("\nResults:");
        for (int i = 0; i < scores.Length; i++)
        {
            Console.WriteLine($"Score: {scores[i]}, Grade: {grades[i]}");

            switch (grades[i])
            {
                case 'A':
                    Console.WriteLine("Excellent work!");
                    break;
                case 'B':
                    Console.WriteLine("Good job!");
                    break;
                case 'C':
                    Console.WriteLine("You passed.");
                    break;
                case 'D':
                    Console.WriteLine("Needs improvement.");
                    break;
                case 'F':
                    Console.WriteLine("Failed. Better luck next time.");
                    break;
            }

            Console.WriteLine(); // spacing
        }
    }
}
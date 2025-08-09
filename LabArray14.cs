using System;

class Program
{
    static void Main()
    {
        int[,] grades = new int[5, 3];
        int[] totals = new int[5];
        string[] names = new string[5];

        // Input names and grades
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter name of student #{0}: ", i + 1);
            names[i] = Console.ReadLine();

            for (int j = 0; j < 3; j++)
            {
                int grade;
                do
                {
                    Console.Write("  Enter grade {0} for {1} (0–100): ", j + 1, names[i]);
                } while (!int.TryParse(Console.ReadLine(), out grade) || grade < 0 || grade > 100);

                  grades[i, j] = grade;
                totals[i] += grade;
            }
        }

        // Ranking (index tracking)
        int[] indices = { 0, 1, 2, 3, 4 };
        for (int i = 0; i < indices.Length - 1; i++)
        {
            for (int j = i + 1; j < indices.Length; j++)
            {
                if (totals[indices[j]] > totals[indices[i]])
                {
                    int temp = indices[i];
                    indices[i] = indices[j];
                    indices[j] = temp;
                }
            }
        }

        // Display Results
        Console.WriteLine("\n--- Student Totals and Rankings ---");
        for (int rank = 0; rank < 5; rank++)
        {
            int idx = indices[rank];
            Console.WriteLine("Rank #{0}: {1} - Total: {2}", rank + 1, names[idx], totals[idx]);
        }
    }
}
using System;

public class Program
{
    public static void Main()
    {
        string[] votes = new string[10];
        int countClifford = 0, countChase = 0, countMax = 0;

        Console.WriteLine("Candidates: Clifford, Chase, Max");

        for (int i = 0; i < votes.Length; i++)
        {
            Console.Write($"Enter vote #{i + 1}: ");
            string vote = Console.ReadLine().ToLower();

            if (vote == "clifford")
                countClifford++;
            else if (vote == "chase")
                countChase++;
            else if (vote == "max")
                countMax++;
            else
                Console.WriteLine("Invalid vote. Ignored.");
        }

        Console.WriteLine("\n--- Voting Results ---");
        Console.WriteLine($"Clifford : {countClifford} vote(s)");
        Console.WriteLine($"Chase : {countChase} vote(s)");
        Console.WriteLine($"Max: {countMax} vote(s)");

        // Determine winner
        string winner;
        if (countClifford > countChase && countClifford > countMax)
            winner = "Clifford";
        else if (countChase > countClifford && countChase > countMax)
            winner = "Chase";
        else if (countMax > countClifford && countMax > countChase)
            winner = "Max";
        else
            winner = "No clear winner (tie)";

        Console.WriteLine($"\nWinner: {winner}");
    }
}
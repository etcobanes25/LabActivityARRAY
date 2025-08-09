using System;
class Program
{
    static void Main()
    {
        string[] symptoms = new string[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter symptom of patient {0}: ", i + 1);
            symptoms[i] = Console.ReadLine().ToLower(); // convert to lowercase
        }

        Console.WriteLine("\nDepartment Assignments:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Patient {0}: ", i + 1);

            switch (symptoms[i])
            {
                case "fever":
                case "cough":
                    Console.WriteLine("General Medicine");
                    break;
                case "injury":
                case "burn":
                    Console.WriteLine("Emergency");
                    break;
                default:
                    Console.WriteLine("Refer to Specialist");
                    break;
            }
        }
    }
}
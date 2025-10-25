using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What percentage did you get on the test? ");
        string answer = Console.ReadLine();
        int percentage = int.Parse(answer);
        string letter = "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.Write($"Your grade is {letter}.");

        if (letter == "A" || letter == "B" || letter == "C")
        {
            Console.Write("You have passed!");
        }
        else
        {
            Console.Write("You have not passed.");
        }






    }
}
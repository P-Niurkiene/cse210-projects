using System;
using System.Runtime.InteropServices.Marshalling;

public partial class Program
{
    static void Main(string[] args)
    {
        Maths mathsAssignment = new Maths("Sam Biggs", "Fractions", "7.3", "1-15");
        Console.WriteLine(mathsAssignment.GetSummary());
        Console.WriteLine(mathsAssignment.GetHomeworkList());

        Console.WriteLine("");

        Writing writingAssignment = new Writing("Sarah Williams", "WW2", "In the Camps");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());

    }
}
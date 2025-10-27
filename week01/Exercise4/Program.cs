using System;
using System.Globalization;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        while (number != 0)
        {
            Console.Write("Enter number: ");
            string entry = Console.ReadLine();
            number = int.Parse(entry);
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }
        Console.WriteLine($"The sum is: {sum}");

        int total = numbers.Count;
        float average = ((float)sum) / total;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int n in numbers)
            if (n > max)
            {
                max = n;
            }
        Console.WriteLine($"The largest number is: {max}");

        int low = numbers[0];
        foreach (int n in numbers)
        {
            if (n < low)
            {
                low = n;
            }
        }
        Console.WriteLine($"The lowest number is: {low}");






    }
}
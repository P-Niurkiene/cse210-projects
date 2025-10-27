using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squared = SquareNumber(userNumber);
        DisplayResults(userName, squared);

    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favourite number: ");
        string number = Console.ReadLine();
        int userNumber = int.Parse(number);
        return userNumber;
    }
    static int SquareNumber(int userNumber)
    {
        int squared = userNumber * userNumber;
        return squared;
    }
    static void DisplayResults(string userName, int squared)
    {
        Console.WriteLine($"{userName}, the square of your number is {squared}");
    }

}
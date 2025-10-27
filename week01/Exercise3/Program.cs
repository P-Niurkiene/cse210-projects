using System;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 100);

        int guess = -1;
        while (guess != magic_number)
        {
            Console.Write("What is your guess? ");
            string reply = Console.ReadLine();
            guess = int.Parse(reply);


            if (guess < magic_number)
            {
                Console.Write("Higher. ");
            }
            else if (guess > magic_number)
            {
                Console.Write("Lower. ");
            }
            else
            {
                Console.Write("You have guessed it!");
            }
        }


    }
}
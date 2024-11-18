using System;
using System.Net;
using System.Security.Cryptography;

class Program
{

    static void Main(string[] args)
    {
        Random randomGenerator = new Random();

        string response;

        do
        {
            int magicNumber = randomGenerator.Next(1, 101);
            int guess = -1;
            Console.WriteLine("What is the Magic number? ");

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }

                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }

                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            Console.Write("Do you want to continue? (yes/no): ");
            response = Console.ReadLine().ToLower();

        
        } while (response == "yes");

        Console.WriteLine("Thanks for playing!");

        
    }
}
using System;

namespace Selection
{

    internal class Program
    {
        static void Guess()
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            Console.WriteLine($"{favNumber}");
            var guessed = false;
            var userInput = -1;
            while (guessed != true)
            {
                userInput = int.Parse(Console.ReadLine());
                if (userInput == favNumber)
                {
                    Console.WriteLine("Congrats, the number was {favNumber}");
                    guessed = true;
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine("Too High");
                }
                else if (userInput < favNumber)
                {
                    Console.WriteLine("Too Low");

                }

            }
        }
        static void Subjects()
        {
            Console.WriteLine("Favorite Subject?");
            var subject = Console.ReadLine();
            switch (subject.ToLower())
            {

                case "biology":
                    Console.WriteLine("Biology is the Best!");
                    break;
                case "math":
                    Console.WriteLine("What is the integral of x^2?");
                    break;
                case "history":
                    Console.WriteLine("Who was the Sun King?");
                    break;
                case "art":
                    Console.WriteLine("Good art makes the world go 'round");
                    break;
                case "computer science":
                    Console.WriteLine("C# is cool and so is Python");
                    break;
                default:
                    Console.WriteLine("Learning is awesome.");
                    break;
            }
        }
        static void Main(string[] args)
        {
            Guess();
            Subjects();
            Console.WriteLine("Program Complete");
        }
    }

}
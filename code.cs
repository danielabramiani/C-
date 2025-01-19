using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numberToGuess = random.Next(1, 101);
            int userGuess = 0;
            int attempts = 0;

            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine("I have selected a number between 1 and 100. Can you guess what it is?");

            while (userGuess != numberToGuess)
            {
                Console.Write("Enter your guess: ");

                try
                {
                    userGuess = int.Parse(Console.ReadLine());
                    attempts++;

                    if (userGuess < numberToGuess)
                    {
                        Console.WriteLine("Too low! Try again.");
                    }
                    else if (userGuess > numberToGuess)
                    {
                        Console.WriteLine("Too high! Try again.");
                    }
                    else
                    {
                        Console.WriteLine($"Congratulations! You guessed the number {numberToGuess} in {attempts} attempts.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }

            Console.WriteLine("Thanks for playing!");
            Console.ReadKey(); 
        }
    }
}

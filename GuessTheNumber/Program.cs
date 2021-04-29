using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            // Variables

            int numberToGuess = new Random().Next(1, 51);

            // Methods

            void askUser()
            {
                // Local variables

                string usersGuess;
                int convertedGuess;

                Console.Write("\nYour guess: ");

                usersGuess = Console.ReadLine();

                try
                {
                    convertedGuess = Convert.ToInt16(usersGuess);

                    if (convertedGuess < numberToGuess)
                    {
                        Console.WriteLine("Your number is too low, try again...");

                        askUser();

                    }
                    else if (convertedGuess > numberToGuess)
                    {
                        Console.WriteLine("Your number is too high, try again...");

                        askUser();

                    } else
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("\nYou guessed the number!");

                        Console.ResetColor();

                        Console.WriteLine($"The number to guess: {numberToGuess}");

                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Well that's not a number, try again..");

                    askUser();

                }
                catch (OverflowException)
                {
                    Console.WriteLine("Maybe a bit out of range, try again...");

                    askUser();

                }

            }
             
            
            // Execution

            Console.WriteLine("Welcome to guess the number!");
            Console.WriteLine("The object of the game; guess the secret number between 1 and 50, you will be told, if your too low or high.");

            askUser();


        }
    }
}

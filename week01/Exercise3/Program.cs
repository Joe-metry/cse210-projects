using System;

class Program
{
    static void Main(string[] args)
    {
        // Exercise 3: Magic Number Game
        //Author: Ubi, Joseph Bassey
        string response;
        do
        {
        int guessCount = 0;
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        while (true)
        {
            Console.Write("What is the magic number? ");
            string input = Console.ReadLine();
            int inputToInt = int.Parse(input);
            guessCount++;
            if (inputToInt > number)
            {
                Console.WriteLine("Too high! Try again.");
            }
            else if (inputToInt < number)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed the magic number!");
                Console.WriteLine($"You made {guessCount} guesses.");
                Console.Write("Do you want to play again? (yes/no) ");
                response = Console.ReadLine().ToLower();
                break;
            }
        }
        } while (response != "no");
    
    }
}
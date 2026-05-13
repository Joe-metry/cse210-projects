using System;

class Program
{
    static void Main(string[] args)
    {
        Welcome();
        string name = AskAnkReturnUserName();
        int favoriteNumber = UsersFavoriteNumber();
        int squaredNumber = AcceptAndSquareAnInteger(favoriteNumber);
        Console.WriteLine($"{name}, the square of your number is: {squaredNumber}");

    }

      static void Welcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string AskAnkReturnUserName()
        {
            Console.Write("enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        static int UsersFavoriteNumber()
        {
            Console.Write("enter your favorite number? ");
            string input = Console.ReadLine();
            int inputToInt = int.Parse(input);
            return inputToInt;
        }
        static int AcceptAndSquareAnInteger(int number)
        {
            return number * number;
        }
}
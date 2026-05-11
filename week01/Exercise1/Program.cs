using System;

class Program
{
    static void Main(string[] args)
    {
        //Author : Ubi, Joseph Bassey
        // Exercise 1: Write a program that asks the user for their first and last name, then prints out a greeting in the format "Your name is [last name], [first name] [last name]."
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");

    }
}
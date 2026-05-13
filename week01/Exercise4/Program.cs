using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
class Program
{
    static void Main(string[] args)
    {
        // This program prompts the user to enter a list of numbers, calculates the
        // largest number, smallest positive number, sum, average, and sorts the list.

        //Author Ubi, Joseph
        int sum = 0;
        int inputToInt;
        int largestNumber;
        int smallestNumber;
        List<int> numbers = new List<int>();
        Console.Write("Enter a list of numbers, type 0 when finished: ");
        string input = Console.ReadLine();
        inputToInt = int.Parse(input);
        while (inputToInt != 0)
        {
            numbers.Add(inputToInt);
            Console.Write("Enter a list of numbers, type 0 when finished: ");
            input = Console.ReadLine();
            inputToInt = int.Parse(input);
        }
        if (numbers.Count > 0)
        {
            largestNumber = numbers[0];
            smallestNumber = numbers[0];
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
                if (numbers[i] > largestNumber)
                {
                    largestNumber = numbers[i];
                }
                if ((numbers[i] > 0) && (numbers[i] < smallestNumber))
                {
                    smallestNumber = numbers[i];
                }
            }
        numbers.Sort();
        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestNumber}");
        Console.WriteLine($"The sum of all numbers is: {sum}");
        Console.WriteLine($"The average of all numbers is: {(double)sum / numbers.Count}");

        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}
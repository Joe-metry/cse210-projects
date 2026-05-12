using System;

class Program
{
    static void Main(string[] args)
    {
        // Exercise 2: Grade Converter
        //Author: Ubi, Joseph Bassey
        string passHint = "";
        string grade = "";
        string gradeSign = "";
        int lastDigit = 0;
        Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine();
        int inputToInt = int.Parse(input);

        if (!(inputToInt >= 97 || inputToInt < 60))
        {
            lastDigit += inputToInt % 10;
            if (lastDigit >= 7)
            {
                gradeSign = "+";
            }
            else if (lastDigit <= 3)
            {
                gradeSign = "-";
            }
        }

        if (inputToInt >= 97)
        {
            grade = "A";
        }
        else if (inputToInt >= 90)
        {
            grade = "A";
        }
        else if (inputToInt >= 80)
        {
            grade = "B";
        }
        else if (inputToInt >= 70)
        {
            grade = "C";
        }
        else if (inputToInt >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        
        if (inputToInt >= 70)
        {
            passHint = "Congratulations! You passed the class!";
        }
        else
        {
            passHint = "Sorry, you did not pass the class. Better luck next time!";
        }
        Console.WriteLine($"Your grade is: {grade}{gradeSign}");
        Console.WriteLine(passHint);
    }
}
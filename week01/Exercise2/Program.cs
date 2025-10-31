using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        
        Console.Write("Hello! What is your name? ");
        string name = Console.ReadLine();
       
        Console.WriteLine($"Welcome {name}! Please include your grade percentage.");
        string value = Console.ReadLine();
        int percent = int.Parse(value);
        string letter  = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }

        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        int lastDigit = percent % 10;
        string sign = "";

        if (lastDigit >= 7)
        {
            sign = "+";

        }
        else if (lastDigit <= 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }
        if (letter == "F")
        {
            sign = "";
        }
        else if (letter == "A" && lastDigit >= 7)
        {
            sign = "";
        }
        Console.WriteLine($"Your grade is {letter+sign}.");
        if (percent >= 70)
        {
            Console.WriteLine("Congratulations! You passed.");
        }
        else
        {
            Console.WriteLine("Better luck next time. Please retake course.");
        }


    }
}
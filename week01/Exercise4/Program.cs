using System;
using System.Globalization;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int> numbers = new List<int>();

        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Welcome, enter a number. [Enter 0 to quit] ");
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int highest = numbers[0];
        foreach (int number in numbers)
        {
            if (number > highest)
            {
                highest = number;
            }
        }
        
            

        Console.WriteLine($"The highest is: {highest}");
        

        
    }
}
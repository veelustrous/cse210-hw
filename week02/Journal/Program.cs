using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // EXTRA FEATURE FOR FULL POINTS:
        // I added colorful console output to enhance the user experience,
        // improve usability, and make prompts/menus visually clear.
        // This exceeds the base requirements by introducing UI design elements.

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Welcome to Your Veelustrous Journal 💖📓");
        Console.ResetColor();

        Journal journal = new Journal();
        List<string> prompts = new List<string>
        {
            "What made you smile today?",
            "What challenged you today?",
            "Who did you appreciate today and why?",
            "What moment would you love to relive?",
            "How did you show kindness today?"
        };

        bool running = true;

        while (running)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n--- Journal Menu ---");
            Console.ResetColor();

            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal");
            Console.WriteLine("4. Load the journal");
            Console.WriteLine("5. Quit");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Choose an option: ");
            Console.ResetColor();

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    Random random = new Random();
                    int index = random.Next(prompts.Count);
                    string selectedPrompt = prompts[index];

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"Prompt: {selectedPrompt}");
                    Console.ResetColor();

                    Console.Write("Your response: ");
                    string response = Console.ReadLine();

                    string date = DateTime.Now.ToString("yyyy-MM-dd");
                    Entry newEntry = new Entry(date, selectedPrompt, response);
                    journal.AddEntry(newEntry);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Entry saved 💅🏽✨");
                    Console.ResetColor();
                    break;

                case "2":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Displaying your journal entries...\n");
                    Console.ResetColor();

                    journal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter filename to save (e.g., journal.txt): ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Journal saved successfully 🎉");
                    Console.ResetColor();
                    break;

                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Journal loaded successfully 🥳");
                    Console.ResetColor();
                    break;

                case "5":
                    running = false;

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Goodbye bestie 😭👋");
                    Console.ResetColor();
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid option, try again 😭");
                    Console.ResetColor();
                    break;
            }
        }
    }
}

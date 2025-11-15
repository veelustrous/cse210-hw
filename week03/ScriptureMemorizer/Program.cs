using System;

class Program
{
    static void Main()
    {
        var library = new ScriptureLibrary();
        var scripture = library.GetRandomScripture();

        while (!scripture.AllHidden())
        {
            Console.Clear();
            scripture.Display();
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            var input = Console.ReadLine();
            if (input?.ToLower() == "quit") break;

            // Hides 2 random words per press
            scripture.HideRandomWords(2);
        }

        // Final display with all hidden words
        Console.Clear();
        scripture.Display();
        Console.WriteLine("\nAll words are hidden! Well done!");
    }
}

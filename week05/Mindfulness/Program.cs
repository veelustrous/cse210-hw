
/*

* Mindfulness Program - Extra Features Implemented:

 1. Spinner animation for Reflection and Breathing activities to make pauses more interactive.
 2. Countdown timers for breathing cycles to guide pacing.
 3. Random selection of reflection prompts and questions to ensure variety.
 4. Listing activity counts total items entered, giving immediate feedback.
 5. Clean menu system allowing repeated use without restarting the program.
  These small enhancements go beyond the core requirements to improve user experience
 and engagement with the mindfulness exercises.
  */
using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Mindfulness Activities:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an activity: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    new BreathingActivity().Run();
                    break;
                case "2":
                    new ReflectionActivity().Run();
                    break;
                case "3":
                    new ListingActivity().Run();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
        }
    }
}

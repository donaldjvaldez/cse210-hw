// Showing Creativity and Exceeding Requirements: I finally was able to made that the questions from _questions at the ReflectingActivity class
// stop repeating in the same session of the program, I make them shuffle at the beggining and then the program goes
// one by one, so it doesnt repeat.
using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }
            else if (choice == "2")
            {
              ReflectingActivity reflecting = new ReflectingActivity();
              reflecting.Run();  
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }
            else if (choice == "4")
            {
             break;   
            }
        }
    }
}
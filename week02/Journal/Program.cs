// Improvements: I decided to set a list of prompts divided by category and give the user the option to 
// chose what they want to talk about in their journal.
using System;

class Program
{
    static void Main(string[] args) {
    PromptGenerator generator = new PromptGenerator();
    Journal journal = new Journal();
    string choice = "";
    while (choice != "5")
    {Console.WriteLine("Please select one of the following choices:");
    Console.WriteLine("1. Write");
    Console.WriteLine("2. Display");
    Console.WriteLine("3. Save");
    Console.WriteLine("4. Load");
    Console.WriteLine("5. Quit");
    Console.Write("What would you like to do? ");
    choice = Console.ReadLine();

        if (choice == "1") {
        generator.ShowCategories();
        Console.Write("Enter category: ");
        string category = Console.ReadLine();

        string prompt = generator.GetRandomPrompt(category);
        Console.WriteLine(prompt);

        Console.Write("Your response: ");
        string response = Console.ReadLine();

        Entry entry = new Entry();
        entry._date = DateTime.Now.ToShortDateString();
        entry._promptText = prompt;
        entry._entryText = response;

        journal.AddEntry(entry);
        }

        else if (choice == "2") 
        {
            journal.DisplayAll();
        }
        else if (choice == "3")
        {
            Console.Write("Enter Filename to save: ");
            string filename = Console.ReadLine();
            journal.SaveToFile(filename);
            Console.WriteLine("Journal Saved!");
        }
        else if (choice == "4")
        {
            Console.Write("Enter Filename to load: ");
            string filename = Console.ReadLine();
            journal.LoadFromFile(filename);
            Console.WriteLine("Journal loaded!");
        }    
    }
}
}
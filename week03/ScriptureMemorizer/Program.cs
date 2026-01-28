// Showing creativity and exceeding core requirements: I decided to implement a new class which is ScriptureLibrary.cs 
// that basicaly stores a couple of scriptures of 4 books, and gives the user the alternative to pick which book's scripture 
// they want to memorize. It follows the same principle of encapsulation, as the rest of the project.
using System;

class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary library = new ScriptureLibrary();

        library.ShowCategories();
        Console.Write("Enter the Number corresponding to the Book you want to memorize the scripture: ");
        string input = Console.ReadLine();

        if (!int.TryParse(input, out int choice))
        {Console.WriteLine("Invalid Input. Exiting ...");
        return;            
        }

        Scripture scripture = library.GetRandomScripture(choice);

        if (scripture == null)
        {Console.WriteLine("Invalid choise. Exiting...");
        return;  
        }
       
        while (!scripture.IsCompletelyHidden())
        {Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
        string userInput = Console.ReadLine();
        if (userInput.ToLower()== "quit"){
            break;            
        }
        scripture.HideRandomWords(3);    
        }
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nAll Words are hidden!");
    }
}
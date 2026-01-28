// Showing creativity and exceeding core requirements: I decided to implement a new class which is ScriptureLibrary.cs 
// that basicaly stores a couple of scriptures of 4 books, and gives the user the alternative to pick which book's scripture 
// they want to memorize. It follows the same principle of encapsulation, as the rest of the project.
public class ScriptureLibrary {
    private List<string> _categories = new List<string>(){
        "Book of Mormon",
        "Old Testament",
        "New Testament",
        "Doctrine & Covenants"
    };
    private Dictionary<string, List<Scripture>> _scriptures = new Dictionary<string, List<Scripture>>();
    

    public ScriptureLibrary() {
        _scriptures["Book of Mormon"] = new List<Scripture>() {
            new Scripture(new Reference("Mosiah", 2, 17), "When ye are in the service of your fellow beings ye are only in the service of your God"),
            new Scripture(new Reference("Ether", 12, 27), "My grace is sufficient for all men that humble themselves before me")
        };
        _scriptures["Old Testament"] = new List<Scripture>() {
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture(new Reference("Isaiah", 1, 18), "Though your sins be as scarlet, they shall be as white as snow")
        };
        _scriptures["New Testament"] = new List<Scripture>() {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his only begotten Son"),
            new Scripture(new Reference("Romans", 8, 28), "All things work together for good to them that love God")
        };
        _scriptures["Doctrine & Covenants"] = new List<Scripture>() {
            new Scripture(new Reference("D&C", 10, 5), "Pray always, that you may conquer Satan"),
            new Scripture(new Reference("D&C", 88, 118), "Seek ye out of the best books words of wisdom; seek learning, even by study and also by faith")
        };
    }
    public void ShowCategories() {
        Console.WriteLine("Choose a category");
        for (int i = 0; i < _categories.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_categories[i]}");
        }
    }
        public Scripture GetRandomScripture(int choice) {
            if (choice >= 1 && choice <= _categories.Count)
            {string category = _categories[choice-1];
            Random random = new Random();
            List<Scripture> scriptures = _scriptures[category];
            int index = random.Next(scriptures.Count);
            return scriptures[index];                
            }
            else
            {
                return null;
        }
    }
}

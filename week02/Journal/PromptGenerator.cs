// Improvements: I decided to set a list of prompts divided by category and give the user the option to 
// chose what they want to talk about in their journal.

public class PromptGenerator {
    private Dictionary<string, List<string>> _categories = new Dictionary<string, List<string>>() {
        { "Daily Life", new List<string>() {
            "What was the best part of your day?",
            "Describe something funny that happened today.",
            "What did you eat for breakfast?"
        }},
        { "School", new List<string>() {
            "What subject do you enjoy the most?",
            "Describe a teacher who inspires you.",
            "What was the most interesting thing you learned today?"
        }},
        { "Feelings", new List<string>() {
            "How are you feeling right now?",
            "What makes you happy?",
            "What makes you nervous?"
        }},
        { "Friends", new List<string>() {
            "Who did you talk to today?",
            "Describe your best friend.",
            "What do you like to do with friends?"
        }},
        { "Future", new List<string>() {
            "What do you want to be when you grow up?",
            "Where would you like to travel?",
            "What is one goal you have for this year?"
        }},
        { "Imagination", new List<string>() {
            "If you could fly, where would you go?",
            "Imagine you found a treasure chest. What’s inside?",
            "If you could meet any famous person, who would it be?"
        }}
    };

    public void ShowCategories() {
        Console.WriteLine("So you want to write, What would you like to write about?:");
        Console.WriteLine("Choose a category and we'll give you a prompt:");
        foreach (var category in _categories.Keys) {
            Console.WriteLine($"- {category}");
        }
    }

    public string GetRandomPrompt(string category) {
        if (_categories.ContainsKey(category)) {
            Random random = new Random();
            List<string> prompts = _categories[category];
            int index = random.Next(prompts.Count);
            return prompts[index];
        }
        else {
            return "Invalid category.";
        }
    }
}

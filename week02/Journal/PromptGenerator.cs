public class PromptGenerator {
    public List<string> _prompts = new List<string>() {
        "What was the best part of your day?",
        "Who did you talk to today?",
        "What are you grateful for?",
        "Describe something funny that happened."
    };

    public string GetRandomPrompt() {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
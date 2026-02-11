// Showing Creativity and Exceeding Requirements: I finally was able to made that the questions from _questions
// stop repeating in the same session of the program, I make them shuffle at the beggining and then the program goes
// one by one, so it doesnt repeat.

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string> {
        "Think of a time you stood up for someone else.",
        "Think of a time you did something really difficult.",
        "Think of a time you helped someone in need."
    };
    private List<string> _questions = new List<string> {
    "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"
};


    public ReflectingActivity() : base("Reflecting Activity", "This Activity will help you reflect on times when you shoed strength.") { }
    
    public void Run() {
        DisplayStartingMessage();
        int duration = GetDuration();
        ShowGetReady();

        Random rand = new Random();
            string prompt = _prompts[rand.Next(_prompts.Count)];
            Console.WriteLine($"Consider the following prompt:\n\"{prompt}\"");
        Console.WriteLine("When you have something in mind, press Enter to continue...");
        Console.ReadLine();

        List<string> shuffledQuestions = _questions.OrderBy(q => rand.Next()).ToList();


        DateTime endTime = DateTime.Now.AddSeconds(duration);
        int index = 0;
        while (DateTime.Now < endTime && index < shuffledQuestions.Count) {
        Console.WriteLine(shuffledQuestions[index]);
        ShowSpinner(10);
        index++;
        } 
        
        DisplayEndingMessage();
    }
}
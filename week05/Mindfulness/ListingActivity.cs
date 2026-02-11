public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>{
        "Who are people you appreciate?",
        "What are personal strengths of yours?",
        "Who have you helped this week?"
    };

    public ListingActivity() : base("Listing Activiity", "This Activity will help you reflect by listing positive things in your life.") { }

    public void Run() {
        DisplayStartingMessage();
        int duration = GetDuration();
        ShowGetReady();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine(prompt);

        List<string> responses = new List<string>();
        while (DateTime.Now < endTime)
        {Console.Write (">");
        responses.Add(Console.ReadLine());            
        }
        Console.WriteLine($"You listed {responses.Count} items!");
        DisplayEndingMessage();
    }
}
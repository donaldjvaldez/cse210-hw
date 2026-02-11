public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description) {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage() {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine(_description);
        Console.WriteLine("How long, in seconds, would you like your session? ");
        _duration = int.Parse(Console.ReadLine());
    }



    public int GetDuration() {
        return _duration;
    }

    public void ShowSpinner(int seconds) {
        string[] spinner = { "|", "/", "-", "\\" };
    DateTime endTime = DateTime.Now.AddSeconds(seconds);
    int i = 0;

    while (DateTime.Now < endTime) {
        Console.Write(spinner[i]);
        Thread.Sleep(750); 
        Console.Write("\b"); 
        i = (i + 1) % spinner.Length;
    }
    Console.WriteLine();
    }
    public void ShowCountdown(int seconds) {
    for (int i = seconds; i > 0; i--) {
        Console.Write(i);
        Thread.Sleep(1000);    
        Console.Write("\b \b");   
    }
    }

    public void DisplayEndingMessage() {
        Console.WriteLine("Well done!");
        ShowSpinner(4);
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}.");
        ShowSpinner(4);
    }


    public void ShowGetReady() {
    Console.WriteLine("Get Ready...");
    ShowSpinner(4);
    }

    
}
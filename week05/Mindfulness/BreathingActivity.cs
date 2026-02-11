public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing Activity", "This Activity will help you relax by guiding you through slow breathing"){}

        public void Run () {
            DisplayStartingMessage();
            int duration = GetDuration();
            ShowGetReady();
            DateTime endTime = DateTime.Now.AddSeconds(duration);

            while (DateTime.Now < endTime)
            {
                Console.Write("Breathe in... ");
                ShowCountdown(4);
                Console.WriteLine();

                Console.Write("Breathe out... ");
                ShowCountdown(6);
                Console.WriteLine();

                Console.WriteLine();
            }
            DisplayEndingMessage();
        }
}
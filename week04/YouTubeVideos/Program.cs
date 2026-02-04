using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Encapsulation Explained", "Donald Valdez", 300);
        Video video2 = new Video("Abstraction in C#", "Jaden Smith", 620);
        Video video3 = new Video("Object Oriented Programming", "Lebron James", 515);
        Video video4 = new Video("Starting programming in C# 2026", "Stephen Curry", 685);

        video1.AddComment(new Comment("Shaq", "Wow! That's amazing!"));
        video1.AddComment(new Comment("Wade", "The best video I've seen"));
        video1.AddComment(new Comment("Kobe", "Watching from heaven"));
        video1.AddComment(new Comment("D-Rose", "Where can I download that extention?"));

        video2.AddComment(new Comment("Duran", "Is not like that"));
        video2.AddComment(new Comment("Booker", "God bless the chanel"));
        video2.AddComment(new Comment("Doncic", "The audio is bad"));
        video2.AddComment(new Comment("Wembanyama", "How can I set the lenguage to French?"));

        video3.AddComment(new Comment("Ja Morant", "Great!"));
        video3.AddComment(new Comment("Karl Towns", "DR in the House"));
        video3.AddComment(new Comment("Mikal Bridge", "it aint working"));
        video3.AddComment(new Comment("Nicola Jokic", "Can you pleace the link in the description?"));

        video4.AddComment(new Comment("Alan Iverson", "How can I sign in for the full curse?"));
        video4.AddComment(new Comment("Al Hordfor", "The first minute is a waste of time"));
        video4.AddComment(new Comment("Austin Reaves", "LA up!"));

        video1.DisplayVideoInfo();
        video1.DisplayAllComments();

        Console.WriteLine();

        video2.DisplayVideoInfo();
        video2.DisplayAllComments();

        Console.WriteLine();

        video3.DisplayVideoInfo();
        video3.DisplayAllComments();

        Console.WriteLine();

        video4.DisplayVideoInfo();
        video4.DisplayAllComments();
    }
}
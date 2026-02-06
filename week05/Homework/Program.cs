using System;

class Program
{
    static void Main(string[] args)
    {
       Assignment a1 = new Assignment("Michael Jordan", "Basic Grammar");
       Console.WriteLine(a1.GetSummary());

       MathAssignment m1 = new MathAssignment("Kyrie Irving", "Fractions", "4.5", "3/8" );
       Console.WriteLine(m1.GetSummary());
       Console.WriteLine(m1.GetHomeworkList());

       WritingAssignment w1 = new WritingAssignment("Sabrina Ionesky", "Programming", "Object Oriented Programming");
        Console.WriteLine(w1.GetSummary());
        Console.WriteLine(w1.GetWritingInformation());

    }
}
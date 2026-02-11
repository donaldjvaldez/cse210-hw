using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Blue", 5);
        shapes.Add(s1);

        Circle s2 = new Circle("Green", 3);
        shapes.Add(s2);

        Rectangle s3 = new Rectangle("Red", 2, 5);
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area} squere feet.");
        }
    }
}
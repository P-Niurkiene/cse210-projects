using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello This is the Shapes project for Polymorphism");

        List<Shape> shapes = new List<Shape>();
        Square s1 = new Square("Pink", 3);
        shapes.Add(s1);

        Rectangle r1 = new Rectangle("Blue", 5, 7);
        shapes.Add(r1);

        Circle c1 = new Circle("Orange", 4);
        shapes.Add(c1);

        foreach (Shape s in shapes)
        {
            string colour = s.GetColour();
            double area = s.GetArea();
            Console.WriteLine($"For the colour {colour} shape the area is {area}");
        }

    }
}
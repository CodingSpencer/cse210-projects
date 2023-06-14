using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        
        Square s1 = new Square("blue", 10);
        shapes.Add(s1);

        Rectangle r1 = new Rectangle("red", 8, 12);
        shapes.Add(r1);

        Circle c1 = new Circle("green", 9);
        shapes.Add(c1);

        foreach (Shape s in shapes) {
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine($"{area} is the area of the {color} shape.");
            
        }

        
    }
}
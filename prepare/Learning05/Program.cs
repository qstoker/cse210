using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapeList = new List<Shape>();
        shapeList.Add(new Square("blue", 3));
        shapeList.Add(new Rectangle("red", 5, 2));
        shapeList.Add(new Circle("yellow", 7.1));

        foreach (Shape shape in shapeList)
        {
            Console.WriteLine($"Color: {shape.GetColor()} - Area: {shape.GetArea()}");
        }
    }
}

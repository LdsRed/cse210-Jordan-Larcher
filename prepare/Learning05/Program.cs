using System;
using Learning05;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");



        List<Shape> shapeList = new List<Shape>(); 

        shapeList.Add(new Square("Black", 4));
        shapeList.Add(new Rectangle("Blue", 10, 20));
        shapeList.Add(new Circle("Yellow", 4.5));



        foreach(Shape shape in shapeList)
        {

            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}");
        }
    }
}
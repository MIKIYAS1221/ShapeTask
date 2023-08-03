// See https://aka.ms/new-console-template for more information

using System;

namespace ShapeTask
{
    
    class Program
    {
        public static void PrintShapeArea(Shape shape)
        {
            Console.WriteLine($"Shape: {shape.Name}, Area: {shape.CalculateArea()}");
        }

        static void Main()
        {
            // Creating instances of Circle, Rectangle, and Triangle
            Circle circle = new Circle { Name = "Circle", Radius = 5 };
            Rectangle rectangle = new Rectangle { Name = "Rectangle", Width = 4, Height = 6 };
            Triangle triangle = new Triangle { Name = "Triangle", Base = 8, Height = 5 };

            // Using the PrintShapeArea method to display the name and area of each shape
            PrintShapeArea(circle);
            PrintShapeArea(rectangle);
            PrintShapeArea(triangle);
        }
    }
}

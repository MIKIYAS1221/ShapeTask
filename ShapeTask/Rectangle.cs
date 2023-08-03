namespace ShapeTask;

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    // Override the CalculateArea method for Rectangle
    public override double CalculateArea()
    {
        return Width * Height;
    }
}
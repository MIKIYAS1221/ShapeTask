namespace ShapeTask;

public class Triangle : Shape
{
    public double Base { get; set; }
    public double Height { get; set; }

    // Override the CalculateArea method for Triangle
    public override double CalculateArea()
    {
        return (Base * Height) / 2;
    }
}
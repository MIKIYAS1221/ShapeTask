namespace ShapeTask;

public class Circle: Shape
{
    
    public double Radius { get; set; }

    // Override the CalculateArea method for Circle
    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    
}
}
namespace ShapeTask;

public class Shape
{
    // Base class
    public string Name { get; set; }
                    
        // Virtual method to be overridden in derived classes
        public virtual double CalculateArea()
        {
            return 0;
        }
    
    
}
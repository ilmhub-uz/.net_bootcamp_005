namespace OOP.Encapsulation;

public class Circle
{
    private readonly double _radius;

    public Circle(double radius)
    {
        this._radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * _radius * _radius;
    }
    
}

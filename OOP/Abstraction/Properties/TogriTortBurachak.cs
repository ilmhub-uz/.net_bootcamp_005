using OOP.Interfaces;

namespace OOP.Abstraction.Properties;

public class TogriTortBurachak : IShape,IPolygon
{
    private readonly double _width;
    private readonly double _height;

    public TogriTortBurachak(double height, double width)
    {
        _height = height;
        _width = width;
    }

    public  double Area
    {
        get
        {
            return _height * _width;
        }
    }

    public double Length
    {
        get
        {
            return (_height + _width) * 2;
        }
    }

    public int NumberOfAngels { get; set; } = 4;

    public int NumberOfSides { get; set; }

    public bool IsClosed { get; set; }

    public double SummOfInternalAngels { get; } = 360;
}
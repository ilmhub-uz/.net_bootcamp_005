namespace OOP.Interfaces;

public interface IPolygon
{
    public int NumberOfAngels { get; set; }
    public int NumberOfSides { get; set; }
    public bool IsClosed { get; set; }
    public double SummOfInternalAngels { get;}
}
using OOP.Interfaces;

namespace OOP.Abstraction.Properties
{
    public class Doira : ICircle
    {
        
        public Doira(double radius)
        {
            Radius = radius;
        }

        public double Area
        {
            get
            {
              return  Math.PI * Math.Pow(Radius, 2);
            }
        }

        public double Length
        {
            get
            {
                return Radius * 2 * Math.PI;
            }
        }

        public  double Diametr
        {
            get
            {
                return Radius *2;
            }
        }

        public double Radius { get; set; }
    }
}
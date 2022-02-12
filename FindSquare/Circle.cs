using FindSquare.Interfaces;

namespace FindSquare
{
    public class Circle : IFigure
    {
        private double radius;
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius is negative");
            }
            this.radius = radius;
        }
        public double GetSquare()
        {
            return Math.PI * Math.Pow(radius,2);
        }
    }
}
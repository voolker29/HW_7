
using FigureClass;

namespace ClassCircle
{
    internal class Circle : Figure
    {
        
        public double R { get; set; }

        private const double pi = 3.14;

        public Circle(double r) 
        {
            R = r;
        }

        public override double GetSquare()

        {
            return pi*(Math.Pow(R,2)) ;
        }


    }
}

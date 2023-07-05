using FigureClass;


namespace ClassTriangle
{
    internal class Triangle:Figure
    {
        public double A { get; set; }
        public double H { get; set; }

        public Triangle( double a ,double h) 
        {
            A = a;
            H = h;
        }
        public override double GetSquare()

        {
            return 0.5*A*H;
        }


    }
}

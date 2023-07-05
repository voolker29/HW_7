using FigureClass;


namespace ClassSquare
{
    internal class Square:Figure
    {
      public double A { get; set; }

     public Square(double a)
        {
            A = a;
        }

    public override double GetSquare()
        {
            return Math.Pow(A,2);
        }
    }
}

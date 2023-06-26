using FigureClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

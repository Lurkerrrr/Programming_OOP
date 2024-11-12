using Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Punkt : IFigure
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Punkt(double x = 0, double y = 0)
        {
            X = x;
            Y = y;
        }

        public static double Distance(Punkt p1, Punkt p2)
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }

        public double Perimeter() => 0;

        public void Move(double dx, double dy)
        {
            X += dx;
            Y += dy;
        }

        public override string ToString() => $"Punkt({X}, {Y})";
    }
}

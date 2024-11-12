using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Trojkat : IFigure
    {
        public Punkt A { get; }
        public Punkt B { get; }
        public Punkt C { get; }

        public Trojkat(Punkt a, Punkt b, Punkt c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double Perimeter() => Punkt.Distance(A, B) + Punkt.Distance(B, C) + Punkt.Distance(C, A);

        public void Move(double dx, double dy)
        {
            A.Move(dx, dy);
            B.Move(dx, dy);
            C.Move(dx, dy);
        }

        public override string ToString() => $"Trojkat(A={A}, B={B}, C={C})";
    }
}

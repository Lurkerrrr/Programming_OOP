using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Polygon : IFigure
    {
        public List<Punkt> Punkty { get; }

        public Polygon(List<Punkt> punkty)
        {
            Punkty = punkty;
        }

        public double Perimeter()
        {
            double perimeter = 0;
            for (int i = 0; i < Punkty.Count; i++)
            {
                perimeter += Punkt.Distance(Punkty[i], Punkty[(i + 1) % Punkty.Count]);
            }
            return perimeter;
        }

        public void Move(double dx, double dy)
        {
            foreach (var point in Punkty)
            {
                point.Move(dx, dy);
            }
        }

        public override string ToString() => $"Polygon(Punkty={string.Join(", ", Punkty)})";
    }
}

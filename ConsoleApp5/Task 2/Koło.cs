using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Kolo : IFigure
    {
        public Punkty Center { get; set; }
        public double Radius { get; set; }

        public Kolo(Punkty center, double radius)
        {
            Center = center;
            Radius = radius;
        }

        public double Perimeter() => 2 * Math.PI * Radius;

        public void Move(double dx, double dy) => Center.Move(dx, dy);

        public override string ToString() => $"Circle(Center={Center}, Radius={Radius})";
    }
}

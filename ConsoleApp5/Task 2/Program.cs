using System;
using System.Collections.Generic;
using System.Drawing;

namespace Figures
{
    class Program
    {
        static void Main()
        {
            var point = new Punkt(1, 2);
            Console.WriteLine(point);

            var circle = new Kolo(new Punkt(0, 0), 5);
            Console.WriteLine(circle);
            circle.Move(2, 3);
            Console.WriteLine("Moved Circle: " + circle);

            var triangle = new Trojkat(new Punkt(0, 0), new Punkt(3, 0), new Punkt(0, 4));
            Console.WriteLine(triangle);

            var polygon = new Polygon(new List<Punkt> { new Punkt(0, 0), new Punkt(4, 0), new Punkt(4, 3), new Punkt(0, 3) });
            Console.WriteLine(polygon);
        }
    }
}

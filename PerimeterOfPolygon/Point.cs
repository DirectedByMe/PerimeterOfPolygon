using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimeterOfPolygon
{
    public class Point
    {
        public int x { get; }
        public int y { get; }
        public string Name { get; }

        public Point(int pointx, int pointy, string nameOfPoint)
        {
            x = pointx;

            y = pointy;

            Name = nameOfPoint;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Point {Name} has coords {x} and {y}");
        }
    }
}

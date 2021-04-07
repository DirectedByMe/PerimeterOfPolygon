using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimeterOfPolygon
{
    public class Polygon
    {
        public string typeOf = "polygon";
        public List<Point> Points;

        public Polygon(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            typeOf = "Triangle";
            Points = new List<Point>() { firstPoint, secondPoint, thirdPoint };
        }

        public Polygon(Point firstPoint, Point secondPoint, Point thirdPoint, Point fourthPoint)
        {
            typeOf = "Quadrangle";
            Points = new List<Point>() { firstPoint, secondPoint, thirdPoint, fourthPoint };
        }

        public Polygon(Point firstPoint, Point secondPoint, Point thirdPoint, Point fourthPoint, Point fifthPoint)
        {
            typeOf = "Pentagon";
            Points = new List<Point>() { fifthPoint, secondPoint, thirdPoint, fourthPoint, fifthPoint };
        }

        private static int SideLength(Point firstPoint, Point secondPoint)
        {
            int result = (int)Math.Sqrt(Math.Pow(firstPoint.x - secondPoint.x, 2) + Math.Pow(firstPoint.y - secondPoint.y, 2));
            return result;
        }

        public int Perimeter()
        {
            int perimeter = 0;
            for (int i = 0; i < Points.Count - 1; i++)
            {
                perimeter += SideLength(Points[i], Points[i + 1]);
            }
            perimeter += SideLength(Points[^1], Points[0]);

            return perimeter;
        }

    }
}

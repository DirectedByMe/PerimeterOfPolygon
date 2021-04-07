using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimeterOfPolygon
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstPoint = new Point(12, 7, "FirstPoint");

            var secondPoint = new Point(5, 10, "SecondPoint");

            var thirdPoint = new Point(2, 8, "ThirdPoint");

            var fourthPoint = new Point(9, 11, "FourthPoint");

            var fifthPoint = new Point(1, 4, "FifthPoint");

            Console.WriteLine("There are fife points:");

            firstPoint.DisplayInfo();

            secondPoint.DisplayInfo();

            thirdPoint.DisplayInfo();

            fourthPoint.DisplayInfo();

            fifthPoint.DisplayInfo();

            var triangle = new Polygon(firstPoint, secondPoint, thirdPoint);

            Console.WriteLine($"PerimeterOfTriangle: {triangle.Perimeter()}");

            var quadrangle = new Polygon(firstPoint, secondPoint, thirdPoint, fourthPoint);

            Console.WriteLine($"PerimeterOfQuadrangle: {quadrangle.Perimeter()}");

            var pentagon = new Polygon(firstPoint, secondPoint, thirdPoint, fourthPoint, fifthPoint);

            Console.WriteLine($"PerimeterOfPentagon: {pentagon.Perimeter()}");

            Console.ReadLine();
        }
    }
}

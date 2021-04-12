using System;
using Xunit;

namespace PerimeterOfPolygon.Test
{    
    public class UnitTestPerimeterOfPolygon
    {
        [Fact]

        public void PolygonTest()
        {
            var pt1 = new Point(12, 9, "Point");

            var pt2 = new Point(1, 14, "Point");

            int result = Polygon.SideLength(pt1, pt2);

            Assert.Equal(12, result);
        }
    }
}

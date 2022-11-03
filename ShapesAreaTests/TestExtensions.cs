using ShapesArea;
using ShapesArea.Visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesAreaTests
{
    public static class TestExtensions
    {
        public static double GetArea(this Shape circle, int digits = 8)
        {
            AreaVisitor areaVisitor = new();
            circle.Accept(areaVisitor);
            var area = areaVisitor.Area;
            var roundedArea = Math.Round(area, digits);
            return roundedArea;
        }
    }
}

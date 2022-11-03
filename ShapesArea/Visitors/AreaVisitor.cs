using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesArea.Visitors
{
    public class AreaVisitor: IShapeVisitor
    {
        private double _area;
        public double Area => _area;
        public void Visit(Circle circle)
        {
            _area = Math.PI * Math.Pow(circle.Radius, 2);
        }
        public void Visit(Triangle triangle)
        {
            var semiper = triangle.Sides.Sum() / 2;
            _area = Math.Sqrt(semiper *
                (semiper - triangle.Sides[0]) *
                (semiper - triangle.Sides[1]) *
                (semiper - triangle.Sides[2]));
        }
    }
}

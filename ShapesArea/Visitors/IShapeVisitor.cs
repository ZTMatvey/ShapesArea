using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesArea.Visitors
{
    public interface IShapeVisitor
    {
        void Visit(Circle circle) { }
        void Visit(Triangle triangle) { }
    }
}

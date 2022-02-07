using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesArea;
using System;

namespace ShapesAreaTests
{
    [TestClass]
    public sealed class CircleTests
    {
        [TestMethod]
        public void Creation()
        {
            var circle = new Circle(10);
            circle = new Circle(110);
            circle = new Circle(32141);
            Assert.ThrowsException<ArgumentException>(()=> circle= new Circle(-11));
            Assert.ThrowsException<ArgumentException>(()=> circle= new Circle(-111));
            Assert.ThrowsException<ArgumentException>(()=> circle= new Circle(-321142));
            Assert.ThrowsException<ArgumentException>(()=> circle= new Circle(0));
        }
        [TestMethod]
        public void AreaCorrect()
        {
            var circle = new Circle(3);
            var area = circle.GetArea();
            var roundedArea = Math.Round(area, 8);
            var expected = 28.27433388;
            Assert.IsTrue(roundedArea == expected);
            ///
            circle = new Circle(234);
            area = circle.GetArea();
            roundedArea = Math.Round(area, 8);
            expected = 172021.04733996;
            Assert.IsTrue(roundedArea == expected);
        }
        [TestMethod]
        public void Equality()
        {
            var circle = new Circle(15);
            var otherCircle = new Circle(15);
            Assert.IsTrue(circle.Equals(otherCircle));
            otherCircle = new Circle(14);
            Assert.IsFalse(circle.Equals(otherCircle));
            Assert.IsFalse(circle.Equals(null));
            var triangle = new Triangle(15, 23, 32);
            Assert.IsFalse(circle.Equals(triangle));
        }
    }
}

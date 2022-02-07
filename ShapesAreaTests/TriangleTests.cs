using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesArea;
using System;

namespace ShapesAreaTests
{
    [TestClass]
    public sealed class TriangleTests
    {
        [TestMethod]
        public void Creation()
        {
            var triangle = new Triangle(345, 234, 478);
            Assert.ThrowsException<ArgumentException>(()=> triangle = new Triangle(-434, 234.543, 234));
            Assert.ThrowsException<ArgumentException>(()=> triangle = new Triangle(-390, -654, -923));
            Assert.ThrowsException<ArgumentException>(()=> triangle = new Triangle(-390, -3, -923));
            Assert.ThrowsException<ArgumentException>(()=> triangle = new Triangle(25.23, 0, 29));
            Assert.ThrowsException<ArgumentException>(()=> triangle = new Triangle(15, 745, 3902.34));
            Assert.ThrowsException<ArgumentException>(()=> triangle = new Triangle(25, 4, 2));
            triangle = new Triangle(new double[] { 34, 65, 47 });
            Assert.ThrowsException<ArgumentException>(() => triangle = new Triangle(new double[] { -324, 456.54, 500 }));
            Assert.ThrowsException<ArgumentException>(() => triangle = new Triangle(new double[] { -98, -73, -54 }));
            Assert.ThrowsException<ArgumentException>(() => triangle = new Triangle(new double[] { -834, -2, -398 }));
            Assert.ThrowsException<ArgumentException>(() => triangle = new Triangle(new double[] { 27, 0, 34 }));
            Assert.ThrowsException<ArgumentException>(() => triangle = new Triangle(new double[] { 273.123, 1, 239 }));
            Assert.ThrowsException<ArgumentException>(() => triangle = new Triangle(new double[] { 3478, 5, 8 }));
        }
        [TestMethod]
        public void AreaCorrect()
        {
            var triangle = new Triangle(3, 4, 5);
            var area = triangle.GetArea();
            var roundedArea = Math.Round(area, 8);
            var expected = 6d;
            Assert.IsTrue(roundedArea == expected);
            ///
            triangle = new Triangle(43, 45, 16);
            area = triangle.GetArea();
            roundedArea = Math.Round(area, 8);
            expected = 343.41811251;
            Assert.IsTrue(roundedArea == expected);
        }
        [TestMethod]
        public void RightCorrect()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRight());
            triangle = new Triangle(6, 8, 10);
            Assert.IsTrue(triangle.IsRight());
            triangle = new Triangle(7, 12, 6);
            Assert.IsFalse(triangle.IsRight());
        }
        [TestMethod]
        public void Equality()
        {
            var triangle = new Triangle(55, 54, 78);
            var otherTriangle = new Triangle(new double[] { 55, 54, 78});
            Assert.IsTrue(triangle.Equals(otherTriangle));
            otherTriangle = new Triangle(new double[] { 23, 34, 54});
            Assert.IsFalse(triangle.Equals(otherTriangle));
            Assert.IsFalse(triangle.Equals(null));
            var circle = new Circle(15);
            Assert.IsFalse(triangle.Equals(circle));
        }
    }
}

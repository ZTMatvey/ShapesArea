using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesArea;
using ShapesArea.Visitors;
using System;

namespace ShapesAreaTests
{
    [TestClass]
    public sealed class TriangleTests
    {
        [TestMethod]
        public void CreationWithNegativeSide()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                Triangle triangle = new (-345, 234, 478);
            });
        }
        [TestMethod]
        public void CreationWithImpossible()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                Triangle triangle = new(2, 2, 100);
            });
        }
        [TestMethod]
        public void AreaCorrect()
        {
            var triangle = new Triangle(3, 4, 5);
            var area = triangle.GetArea();
            var expected = 6d;
            Assert.IsTrue(area == expected);
        }
        [TestMethod]
        public void AreaNotCorrect()
        {
            var triangle = new Triangle(2, 2, 2);
            var area = triangle.GetArea();
            var expected = 2d;
            Assert.IsFalse(area == expected);
        }
        [TestMethod]
        public void RightCorrect()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRight());
        }
        [TestMethod]
        public void RightNotCorrect()
        {
            var triangle = new Triangle(7, 12, 6);
            Assert.IsFalse(triangle.IsRight());
        }
    }
}

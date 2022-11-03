using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesArea;
using ShapesArea.Visitors;
using System;

namespace ShapesAreaTests
{
    [TestClass]
    public sealed class CircleTests
    {
        [TestMethod]
        public void CreationWithNegativeRadius()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                Circle circle = new(-11);
            });
        }
        [TestMethod]
        public void CreationWithZeroRadius()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                Circle circle = new(0);
            });
        }
        [TestMethod]
        public void AreaCorrect()
        {
            var circle = new Circle(3);
            var area = circle.GetArea();
            var expected = 28.27433388;
            Assert.IsTrue(area == expected);
        }
        [TestMethod]
        public void AreaNotCorrect()
        {
            var circle = new Circle(4);
            var area = circle.GetArea();
            var expected = 16;
            Assert.IsFalse(area == expected);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaLib.BaseFigures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLib.BaseFigures.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        public void CircleCreateTest()
        {
            Assert.ThrowsException<ArgumentException>(() => FigureCreator.Create(FigureCreator.FigureType.Circle, -1));
            Assert.ThrowsException<ArgumentException>(() => FigureCreator.Create(FigureCreator.FigureType.Circle, 1, 9));
            Assert.IsInstanceOfType(FigureCreator.Create(FigureCreator.FigureType.Circle, 1), typeof(Circle));
        }


        [TestMethod()]
        public void CircleCreateStringTest()
        {
            Assert.ThrowsException<ArgumentException>(() => FigureCreator.Create("Circle", -1));
            Assert.ThrowsException<ArgumentException>(() => FigureCreator.Create("Circle", 1, 9));
            Assert.IsInstanceOfType(FigureCreator.Create("Circle", 1), typeof(Circle));
        }


        [TestMethod()]
        public void EvaluateArea_SendRadiusOfOne()
        {
            var circle = FigureCreator.Create(FigureCreator.FigureType.Circle, 1);

            var area = circle.EvaluateArea();

            Assert.AreEqual(3.1415926535897932384626433832795, area);
        }

        [TestMethod()]
        public void EvaluateArea_SendRadiusOfTen()
        {
            var circle = FigureCreator.Create(FigureCreator.FigureType.Circle, 10);

            var area = circle.EvaluateArea();

            Assert.AreEqual(314.15926535897932384626433832795, area);
        }
    }
}
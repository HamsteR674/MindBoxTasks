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
    public class TriangleTests
    {
        [TestMethod()]
        public void TriangleCreateTest_SendWrongArgs_MustBeThrowExc()
        {
            Assert.ThrowsException<ArgumentException>(() => FigureCreator.Create(FigureCreator.FigureType.Triangle, -1));
            Assert.ThrowsException<ArgumentException>(() => FigureCreator.Create(FigureCreator.FigureType.Triangle, 1));
            Assert.ThrowsException<ArgumentException>(() => FigureCreator.Create(FigureCreator.FigureType.Triangle, 1));
            Assert.ThrowsException<ArgumentException>(() => FigureCreator.Create(FigureCreator.FigureType.Triangle, 1));
        }


        [TestMethod()]
        public void TriangleCreateStringTest_SendWrongArgs_MustBeThrowExc()
        {
            Assert.ThrowsException<ArgumentException>(() => FigureCreator.Create("Triangle", -1, 1, 1));
            Assert.ThrowsException<ArgumentException>(() => FigureCreator.Create("Triangle", 1, -1, 1));
            Assert.ThrowsException<ArgumentException>(() => FigureCreator.Create("Triangle", 1, 1, -1));
            Assert.ThrowsException<ArgumentException>(() => FigureCreator.Create("Triangle", 1, 1, 1, 1, 1));
        }

        [TestMethod()]
        public void EvaluateArea_SendSidesOfOne()
        {
            var triangle = FigureCreator.Create(FigureCreator.FigureType.Triangle, 1, 1, 1);

            var Area = triangle.EvaluateArea();

            Assert.AreEqual(0.4330127018922193, Area);
        }

        [TestMethod()]
        public void EvaluateArea_SendSidesOfTen()
        {
            var triangle = FigureCreator.Create(FigureCreator.FigureType.Triangle, 10, 10, 10);

            var Area = triangle.EvaluateArea();

            Assert.AreEqual(43.30127018922193, Area);
        }

        [TestMethod()]
        public void IsRightAngled_Send345_MustBeRight()
        {
            var triangle = FigureCreator.Create(FigureCreator.FigureType.Triangle, 3, 4, 5) as Triangle;

            Assert.IsTrue(triangle?.IsRightAngled());
        }

        [TestMethod()]
        public void IsRightAngled_Send346_MustBeWrong()
        {
            var triangle = FigureCreator.Create(FigureCreator.FigureType.Triangle, 3, 4, 6) as Triangle;

            Assert.IsFalse(triangle?.IsRightAngled());
        }
    }
}
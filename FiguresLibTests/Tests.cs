using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FiguresLib;

namespace FiguresLibTests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void WrongCircleRadiusTest()
        {
            //assert
            Assert.ThrowsException<Exception>(() =>
            {
                Circle c = new Circle(-5);
            });
        }

        [TestMethod]
        public void CalculateCircleAreaTest()
        {
            //arrange
            double radius = 2.5;

            double expected = Math.Pow(Math.PI, 2) * radius;

            Circle circle = new Circle(radius);

            //act
            double area = circle.CalculateArea();

            //assert
            Assert.AreEqual(expected, area);
        }

        [TestMethod]
        public void WrongTriangleSidesTest1()
        {
            //assert
            Assert.ThrowsException<Exception>(() =>
            {
                Triangle triangle = new Triangle(-5, 5, 3);
            });
        }

        [TestMethod]
        public void WrongTriangleSidesTest2()
        {
            //assert
            Assert.ThrowsException<Exception>(() =>
            {
                Triangle triangle = new Triangle(15, 5, 3);
            });
        }

        [TestMethod]
        public void CalculateTriangleArea()
        {
            //arrange
            double firstSide = 5;
            double secondSide = 2.5;
            double thirdSide = 4.25;

            double halfPerimeter = (firstSide + secondSide + thirdSide) / 2;
            double expected = Math.Sqrt(halfPerimeter * (halfPerimeter - firstSide) * (halfPerimeter - secondSide) * (halfPerimeter - thirdSide));

            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);

            //act
            double area = triangle.CalculateArea();

            //assert
            Assert.AreEqual(expected, area);
        }

        [TestMethod]
        public void IsTriangleRight()
        {
            //arrange
            double firstSide = 5;
            double secondSide = 4;
            double thirdSide = 3;

            bool expected = true;

            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);

            //act
            bool isRigth = triangle.IsTriangleRigth();

            //assert
            Assert.AreEqual(expected, isRigth);
        }

        [TestMethod]
        public void CalculateAreaOfUnknownFigure()
        {
            //arrange
            double radius = 2.5;

            double expected = Math.Pow(Math.PI, 2) * radius;

            Figure figure = new Circle(radius);

            //act
            double area = figure.CalculateArea();

            //assert
            Assert.AreEqual(expected, area);
        }
    }
}

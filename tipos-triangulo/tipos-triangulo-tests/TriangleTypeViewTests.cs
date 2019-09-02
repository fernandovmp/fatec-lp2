using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using tipos_triangulo;

namespace tipos_triangulo_tests
{
    [TestClass]
    public class TriangleTypeViewTests
    {
        [TestMethod]
        public void TestEquilateralTriangle_A()
        {
            // Arrange
            double sideA = 6;
            double sideB = 6;
            double sideC = 6;
            TriangleType expected = TriangleType.Equilateral;
            TriangleTypeView triangleTypeView = new TriangleTypeView();

            // Act
            TriangleType type = triangleTypeView.TypeOfTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual(expected, type);
        }
        [TestMethod]
        public void TestEquilateralTriangle_B()
        {
            // Arrange
            double sideA = 1.5;
            double sideB = 1.5;
            double sideC = 1.5;
            TriangleType expected = TriangleType.Equilateral;
            TriangleTypeView triangleTypeView = new TriangleTypeView();

            // Act
            TriangleType type = triangleTypeView.TypeOfTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual(expected, type);
        }
        [TestMethod]
        public void TestIsoscelesTriangle_A()
        {
            // Arrange
            double sideA = 7;
            double sideB = 5;
            double sideC = 7;
            TriangleType expected = TriangleType.Isosceles;
            TriangleTypeView triangleTypeView = new TriangleTypeView();

            // Act
            TriangleType type = triangleTypeView.TypeOfTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual(expected, type);
        }
        [TestMethod]
        public void TestIsoscelesTriangle_B()
        {
            // Arrange
            double sideA = 6;
            double sideB = 6;
            double sideC = 10;
            TriangleType expected = TriangleType.Isosceles;
            TriangleTypeView triangleTypeView = new TriangleTypeView();

            // Act
            TriangleType type = triangleTypeView.TypeOfTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual(expected, type);
        }
        [TestMethod]
        public void TestScaleneTriangle_A()
        {
            // Arrange
            double sideA = 6;
            double sideB = 7;
            double sideC = 8;
            TriangleType expected = TriangleType.Scalene;
            TriangleTypeView triangleTypeView = new TriangleTypeView();

            // Act
            TriangleType type = triangleTypeView.TypeOfTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual(expected, type);
        }
        [TestMethod]
        public void TestScaleneTriangle_B()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            TriangleType expected = TriangleType.Scalene;
            TriangleTypeView triangleTypeView = new TriangleTypeView();

            // Act
            TriangleType type = triangleTypeView.TypeOfTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual(expected, type);
        }
        [TestMethod]
        public void TestIsNotTriangle_A()
        {
            // Arrange
            double sideA = 3;
            double sideB = 8;
            double sideC = 4;
            TriangleType expected = TriangleType.None;
            TriangleTypeView triangleTypeView = new TriangleTypeView();

            // Act
            TriangleType type = triangleTypeView.TypeOfTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual(expected, type);
        }
        [TestMethod]
        public void TestIsNotTriangle_B()
        {
            // Arrange
            double sideA = 6;
            double sideB = 6;
            double sideC = 12.1;
            TriangleType expected = TriangleType.None;
            TriangleTypeView triangleTypeView = new TriangleTypeView();

            // Act
            TriangleType type = triangleTypeView.TypeOfTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual(expected, type);
        }
    }
}

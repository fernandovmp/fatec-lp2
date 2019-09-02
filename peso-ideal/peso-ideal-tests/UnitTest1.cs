using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using peso_ideal;

namespace peso_ideal_tests
{
    [TestClass]
    public class IdealWeightViewTests
    {
        [TestMethod]
        public void CalculateMaleIdealWeight_A()
        {
            // Arrange
            double height = 1.60;
            char gender = 'M';
            double expected = 58.32;
            IdealWeightView idealWeightView = new IdealWeightView();

            // Act
            double idealWeight = idealWeightView.CalculateIdealWeight(height, gender);

            // Assert
            Assert.AreEqual(expected, idealWeight);
        }
        [TestMethod]
        public void CalculateMaleIdealWeight_B()
        {
            // Arrange
            double height = 1.80;
            char gender = 'M';
            double expected = 72.86;
            IdealWeightView idealWeightView = new IdealWeightView();

            // Act
            double idealWeight = idealWeightView.CalculateIdealWeight(height, gender);

            // Assert
            Assert.AreEqual(expected, idealWeight);
        }
        [TestMethod]
        public void CalculateMaleIdealWeight_C()
        {
            // Arrange
            double height = 1.77;
            char gender = 'M';
            double expected = 70.68;
            IdealWeightView idealWeightView = new IdealWeightView();

            // Act
            double idealWeight = idealWeightView.CalculateIdealWeight(height, gender);

            // Assert
            Assert.AreEqual(expected, idealWeight);
        }
        [TestMethod]
        public void CalculateFemaleIdealWeight_A()
        {
            // Arrange
            double height = 1.60;
            char gender = 'F';
            double expected = 54.66;
            IdealWeightView idealWeightView = new IdealWeightView();

            // Act
            double idealWeight = idealWeightView.CalculateIdealWeight(height, gender);

            // Assert
            Assert.AreEqual(expected, idealWeight);
        }
        [TestMethod]
        public void CalculateFemaleIdealWeight_B()
        {
            // Arrange
            double height = 1.72;
            char gender = 'F';
            double expected = 62.11;
            IdealWeightView idealWeightView = new IdealWeightView();

            // Act
            double idealWeight = idealWeightView.CalculateIdealWeight(height, gender);

            // Assert
            Assert.AreEqual(expected, idealWeight);
        }
        [TestMethod]
        public void CalculateFemaleIdealWeight_C()
        {
            // Arrange
            double height = 1.69;
            char gender = 'F';
            double expected = 60.25;
            IdealWeightView idealWeightView = new IdealWeightView();

            // Act
            double idealWeight = idealWeightView.CalculateIdealWeight(height, gender);

            // Assert
            Assert.AreEqual(expected, idealWeight);
        }
    }
}

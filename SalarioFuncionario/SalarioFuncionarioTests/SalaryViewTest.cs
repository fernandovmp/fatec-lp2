using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalarioFuncionario;

namespace SalarioFuncionarioTests
{
    [TestClass]
    public class SalaryViewTest
    {
        [TestMethod]
        public void InssTest_1()
        {
            // Arrange
            var salaryView = new SalaryView();
            double salary = 1000;
            double expected = 86.50;

            // Act
            double inss = salaryView.InssDiscount(salary);

            // Assert
            Assert.AreEqual(expected, inss);

        }

        [TestMethod]
        public void IrpfTest_1()
        {
            // Arrange
            var salaryView = new SalaryView();
            double salary = 1000;
            double expected = 0;

            // Act
            double irpf = salaryView.IrpfDiscount(salary);

            // Assert
            Assert.AreEqual(expected, irpf);
        }

        [TestMethod]
        public void ChildAllowanceTest_1()
        {
            // Arange
            var salaryView = new SalaryView();
            double salary = 1000;
            int childCount = 2;
            double expected = 0;

            // Act
            double childAllowance = salaryView.ChildAllowance(salary, childCount);

            // Assert
            Assert.AreEqual(expected, childAllowance);
        }
    }
}

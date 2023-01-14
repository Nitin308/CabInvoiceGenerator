using Microsoft.VisualStudio.TestTools.UnitTesting;
using CabInvoiceGenerator;
using System;

namespace CabInvoiceGeneratorTesting
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            double distance = 5;
            int time = 6;
            double expected = 56;
            //Act
            double actual = invoiceGenerator.CalculateFare(distance, time);
            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
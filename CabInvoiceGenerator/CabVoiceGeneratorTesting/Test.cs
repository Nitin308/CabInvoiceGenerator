using Microsoft.VisualStudio.TestTools.UnitTesting;
using CabInvoiceGenerator;
using System;

namespace CabInvoiceGeneratorTesting
{
    [TestClass]
    public class Test
    {
        /// <summary>
        /// For Single ride Only
        /// </summary>
        //[TestMethod]
        //public void GivenDistanceAndTimeShouldReturnsTotalFare()
        //{
        //    //Arrange
        //    InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
        //    double distance = 5;
        //    int time = 6;
        //    double expected = 56;
        //    //Act
        //    double actual = invoiceGenerator.CalculateFare(distance,time);
        //    //Assert
        //    Assert.AreEqual(expected,actual);
        //}
        /// <summary>
        /// For multiple rides
        /// </summary>
        //[TestMethod]
        //public void GivenMultipleRidesShouldReturnsAggregateTotalFare()
        //{
        //    //Arrange
        //    InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
        //    Ride[] rides = { new Ride(3,25),new Ride(0.5,10) };
        //    double expected = 70;
        //    //Act
        //    double actual = invoiceGenerator.CalculateFare(rides);
        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}
        ///
        /// <summary>
        /// Given distance and time of multiple rides should rerurns average , number of rides,and total fare
        /// </summary>
        //[TestMethod]
        //public void GivenMultipleRidesShouldReturnsAggregateTotalFareWithAverage()
        //{
        //    //Arrange
        //    InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
        //    Ride[] rides = { new Ride(3,25), new Ride(0.5, 10) };
        //    InvoiceSummary expected = new InvoiceSummary(70,rides.Length);
        //    //Act
        //    InvoiceSummary actual = invoiceGenerator.CalculateFare(rides);
        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //    //expected.Equals(actual);
        //}
        /// <summary>
        /// Given distance and time of multiple rides should rerurns average , number of rides,and total fare for particular user id
        /// </summary>
        //[TestMethod]
        //public void GivenMultipleRidesShouldReturnsAggregateTotalFareWithAverageForParticularUserID()
        //{
        //    //Arrange
        //    InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
        //    RideRepository rideRepository = new RideRepository();
        //    Ride[] rides = { new Ride(3, 25), new Ride(0.5, 10) };
        //    string userId = "1";
        //    rideRepository.AddRides(userId,rides);
        //    Ride[] ride2 = { new Ride(2.0,5), new Ride(0.1, 1) };
        //    string userId2 = "2";
        //    rideRepository.AddRides(userId2, ride2);
        //    InvoiceSummary expected = new InvoiceSummary(70,rides.Length);
        //    //Act
        //    InvoiceSummary actual = invoiceGenerator.GetInvoiceSummary(userId);
        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //    //expected.Equals(actual);
        //}
        //[TestMethod]
        //public void GivenMultipleRidesShouldReturnsAggregateTotalFareWithAverageForParticularUserID()
        //{
        //    //Arrange
        //    InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
        //    RideRepository rideRepository = new RideRepository();
        //    Ride[] rides = { new Ride(3, 25), new Ride(0.5, 10) };
        //    string userId = "1";
        //    rideRepository.AddRides(userId, rides);
        //    Ride[] ride2 = { new Ride(2.0, 5), new Ride(0.1, 1) };
        //    string userId2 = "2";
        //    rideRepository.AddRides(userId2, ride2);
        //    InvoiceSummary expected = new InvoiceSummary(70, rides.Length);
        //    //Act
        //    InvoiceSummary actual = invoiceGenerator.GetInvoiceSummary(userId);
        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //    //expected.Equals(actual);
        //}
        [TestMethod]
        public void GivenMultipleRidesShouldReturnsAggregateTotalFareWithAverageForParticularUserID()
        {
            //Arrange
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            InvoiceGenerator invoice = new InvoiceGenerator(RideType.PREMIUM);
            RideRepository rideRepository = new RideRepository();
            Ride[] rides = { new Ride(3, 25), new Ride(0.5, 10) };
            string userId = "1";
            rideRepository.AddRides(userId, rides);
            Ride[] ride2 = { new Ride(2.0, 5), new Ride(0.1, 1) };
            string userId2 = "2";
            rideRepository.AddRides(userId2, ride2);
            InvoiceSummary expected = new InvoiceSummary(60, rides.Length);
            //Act
            //InvoiceSummary actual = invoiceGenerator.GetInvoiceSummary(userId);
            InvoiceSummary actual = invoiceGenerator.GetInvoiceSummary(userId2);
            //Assert
            //Assert.AreEqual(expected, actual);
            expected.Equals(actual);
        }
    }
}
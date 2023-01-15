using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class InvoiceSummary
    {
        /// <summary>
        /// Declaring variables
        /// </summary>
        public double totalFare;
        public double average;
        public int numOfRides;
        /// <summary>
        /// Creating a constructor which returns average , number of rides,and total fare
        /// </summary>
        /// <param name="totalFare"></param>
        /// <param name="numOfRides"></param>
        public InvoiceSummary(double totalFare, int numOfRides)
        {
            this.numOfRides = numOfRides;
            this.totalFare = totalFare;
            this.average = totalFare / numOfRides;
        }
        /// <summary>
        ///Override equal method to checking object which is passed in method is matching with InvoiceSummary object or not
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is InvoiceSummary))
            {
                return false;
            }
            InvoiceSummary invoiceSummary = (InvoiceSummary)obj;
            return this.numOfRides == invoiceSummary.numOfRides && this.totalFare == invoiceSummary.totalFare && this.average == invoiceSummary.average;

        }
    }
}
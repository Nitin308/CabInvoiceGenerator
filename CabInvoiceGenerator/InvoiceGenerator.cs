using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class InvoiceGenerator
    {
        /// <summary>
        /// Declaring some variable
        /// </summary>
        private readonly double MINIMUM_COST_PER_KM;
        private readonly double COST_PER_TIME;
        private readonly double MINIMUM_FARE;
        /// <summary>
        /// Creating a constructor
        /// </summary>
        public InvoiceGenerator()
        {
            this.MINIMUM_COST_PER_KM = 10;
            this.COST_PER_TIME = 1;
            this.MINIMUM_FARE = 5;
        }
        /// <summary>
        /// Creating method for calculating Totalfare based on distance and time
        /// </summary>
        /// <param name="distance"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public double CalculateFare(double distance, int time)
        {
            double totalFare = 0;
            try
            {
                if (distance <= 0)
                {
                    throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_DISTANCE, "Invalid Distance");
                }
                if (time <= 0)
                {
                    throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_DISTANCE, "Invalid Time");
                }

                totalFare = distance * MINIMUM_COST_PER_KM + time * COST_PER_TIME;
            }
            catch (CabInvoiceException e)
            {
                Console.WriteLine(e.Message);
            }
            return Math.Max(totalFare, MINIMUM_FARE);
        }
        /// <summary>
        /// Creating method for calculating Totalfare of multiple rides based on distance and time
        /// </summary>
        /// <param name="rides"></param>
        /// <returns></returns>
        /// <exception cref="CabInvoiceException"></exception>
        public double CalculateFare(Ride[] rides)
        {
            double totalFare = 0;
            try
            {
                foreach (Ride ride in rides)
                {
                    totalFare += CalculateFare(ride.distance, ride.time);
                }
            }
            catch (Exception)
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.NULL_RIDE, "Ride should not be null");
            }
            return Math.Max(totalFare, MINIMUM_FARE);
        }
    }
}
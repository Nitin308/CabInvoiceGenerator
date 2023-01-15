using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class RideRepository
    {
        /// <summary>
        /// Declaring dictionary for storing list of rides for different user
        /// </summary>
        static Dictionary<string, List<Ride>> dict = new Dictionary<string, List<Ride>>();
        /// <summary>
        /// Adding user id and list os rides in dictionary
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="rides"></param>
        /// <exception cref="CabInvoiceException"></exception>
        public void AddRides(string userId, Ride[] rides)
        {
            try
            {
                bool check = dict.ContainsKey(userId);
                if (!check)
                {
                    List<Ride> list = new List<Ride>();
                    list.AddRange(rides);
                    dict.Add(userId, list);
                }
                else
                {
                    foreach (var id in dict.Keys)
                    {
                        if (id == userId)
                        {
                            dict[userId].AddRange(rides);
                        }
                    }
                }
            }
            catch (CabInvoiceException)
            {
                if (rides == null)
                {
                    throw new CabInvoiceException(CabInvoiceException.ExceptionType.NULL_RIDE, "Ride should not be null");
                }
            }
        }
        /// <summary>
        /// Getting array of multiple rides for particular user id
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        /// <exception cref="CabInvoiceException"></exception>
        public static Ride[] GetRides(string userId)
        {
            try
            {
                return dict[userId].ToArray();
            }
            catch (CabInvoiceException)
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_ID, "User ID is invalid");
            }
        }
    }
}
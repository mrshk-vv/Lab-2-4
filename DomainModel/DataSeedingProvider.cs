using DomainModel.Models;
using System;

namespace DomainModel
{
    public class DataSeedingProvider
    {
        private static Random _random;

        public static readonly Array Hostels = Enum.GetValues(typeof(Hostel));

        public static readonly Array Floors = Enum.GetValues(typeof(Floor));

        public static readonly Array Capacities = Enum.GetValues(typeof(Capacity));


        public static Random Randomizer
        {
            get
            {
                if (_random is null)
                {
                    _random = new Random();
                    return _random;
                }

                return _random;
            }
            
        }

        public static DateTime GetRandomDate()
        {
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(Randomizer.Next(range));
        }
    }
}

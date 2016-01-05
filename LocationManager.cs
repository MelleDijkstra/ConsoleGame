using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    class LocationManager
    {
        private static List<LocationBase> _locationList = new List<LocationBase>();

        public static void RegisterLocation(LocationBase location)
        {
            _locationList.Add(location);
            Console.WriteLine(location.GetType().Name + " with ID: " + location.getId() + " added to location list");
        }

        public static LocationBase GetLocationByIndex(int index)
        {
            return _locationList[index];
        }

        public new static string ToString()
        {
            string rtn = "Locations: ";
            foreach (LocationBase location in _locationList)
            {
                rtn += "\n" + location.GetType().Name + ", with ID: " + location.getId();
            }
            return rtn;
        }

        public static void removeLocation(LocationBase location)
        {
            _locationList.Remove(location);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Method
{
   static class ExtensionList
    {
        public static List<T> RemoveDuplicate<T>(this List<T> allcities)
        {
            List<T> finalCities = new List<T>();
            foreach (var eachCity in allcities)
                if (!finalCities.Contains(eachCity))
                    finalCities.Add(eachCity);
            return finalCities;
        }
    }
}

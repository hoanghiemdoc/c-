using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extension_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = "great britain";
            Console.WriteLine(country.FirstLetterLower());

            // use list
            List<string> cites = new list<string>();
            cites.Add("seoul");
            cites.Add("beijing");
            cites.Add("berline");
            cites.Add("Istanbul");
            cites.Add("seoul");
            cites.Add("Istanbul");
            cites.Add("Paris");

            List<string> result = cites.RemoveDuplicated();
            foreach (string city in result)
                Console.WriteLine(city);
        }
    }
}

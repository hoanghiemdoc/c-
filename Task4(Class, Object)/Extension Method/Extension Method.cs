using System;
using System.Collections.Generic;

namespace Extension_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = "Great Britain";
            //Calling the extension method
            Console.WriteLine(country.FirstLetterLower());

            //use List
            List<string> cities = new List<string>();
            cities.Add("Seoul");
            cities.Add("Beijing");
            cities.Add("Berlin");
            cities.Add("Istanblu");
            cities.Add("Seoul");
            cities.Add("Istanbul");
            cities.Add("Paris");

            List<string> result = cities.RemoveDuplicate();
            foreach (string city in result)
                Console.WriteLine(city);
        }
    }
}

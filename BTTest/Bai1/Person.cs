using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Person
    {
        public int Age { get; set; }
        public string FirtsName { get; set; }
        public string LastName { get; set; }

        public Person() { }
        public Person(string firstName, string lastName, int age)
        {
            Age = age;
            FirtsName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"Name : {FirtsName}  {LastName}, Age : {Age}";
        }
    }
}

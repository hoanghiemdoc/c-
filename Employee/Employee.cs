using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Employee
    {
        public string firstName;
        public string lastName;
        public string address;
        public long sin;
        public double salary;

        public Employee(string firstName, string LastName, string address, long sin, double salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.salary = salary;
            this.sin = sin;

        }

        public override string ToString()
        {
            return "name:" + firstName + " " + "\naddress: " + address+ "\nsin:" + sin + "\nsalary" + salary;
        }

        public double Bouns(double bouns)
        {
            return salary * bouns / 100;
        }


    }
}

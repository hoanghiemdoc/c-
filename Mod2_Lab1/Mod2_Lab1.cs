using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1
{
    class Mod2_Lab1
    {
        public class Employee
        {
            private static int employeeCount = 1;

            private string employeeName;
            private double employeeBaseSalary;
            private int employeeId;

            public string Name
            {
                get
                {
                    return employeeName;
                }

                set
                {
                    employeeName = value;
                }
            }
            public double BaseSalary
            {
                get
                {
                    return employeeBaseSalary;
                }
                set
                {
                    employeeBaseSalary = value;
                }
            }

            public int ID
            {
                get
                {
                    return employeeId;
                }
                set
                {
                    employeeId = value;
                }
            }
            public Employee(string name, double baseSalary)
            {
                this.Name = name;
                this.BaseSalary = baseSalary;
                this.ID = employeeCount++;
            }

            public double getBaseSalary()
            {
                return this.BaseSalary;

            }

            public int getEmployeeID()
            {
                return this.ID;

            }

            public String  toString ()
            {
                return this.ID+""+this.Name;

            }

            public virtual String employeeStatus()
            {
                return toString() + "is in the comapny";

            }
        }

       

    }
}

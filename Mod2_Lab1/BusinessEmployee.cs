using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1
{
    class BusinessEmployee : Employee
    {
        public double bonusBudget = 1000;

        public  BusinessEmployee(string name):base(name,50000)
        {

        }
        public override string employeeStatus()
        {
            return this.ToString() + "with a budget of" + this.bonusBudget;
        }
    }
}

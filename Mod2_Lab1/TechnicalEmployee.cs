﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1
{
    class TechnicalEmployee : Employee
    {
        public int successfulCheckIns = 5;

        public TechnicalEmployee(string name): base(name,75000)
        {

        }

        public override String employeeStatus()
        {
            return this.ToString() + "has" + this.successfulCheckIns+"successfull"
        }
    }
}

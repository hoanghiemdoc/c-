using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetails
{
    class OptionalParameterExample
    {
       public void printMessage(String message = "Hello user!")
        {
            Console.WriteLine("{0}", message);
        }
    }
}

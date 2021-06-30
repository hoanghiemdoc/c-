using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialMethod
{
    partial class Shape
    {
        partial void Create()
        {
            Console.WriteLine("Creating Shape ");
        }
        public void Test()
        {
            Create();
        }
    }
}

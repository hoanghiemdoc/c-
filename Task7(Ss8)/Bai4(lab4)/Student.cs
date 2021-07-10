using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_lab4_
{
    class Student : Person
    {
        string enrolled;

        public Student(string enrolled, string name, string clas, string address,string phone,string email) : base(name,phone,address,email,clas)
        {
            this.enrolled = enrolled;
        }
        public String display()
        {
            return "Student's Informattion : "+  "enrolled :  "+ enrolled;
        }
    }
}

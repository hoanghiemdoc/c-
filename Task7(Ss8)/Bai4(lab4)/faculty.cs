using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_lab4_
{
    class faculty : Employee
    {
        public string rank;
        public string timeworks;
        int week = 0;
        public faculty(string department, double salary, string name, string clas, string phone, string address,string email, int officehour, string rank, string timeworks) : base(department, salary, name, phone, address,email, officehour,clas)
        {
            this.rank = rank;
            this.timeworks = timeworks;
        }

        public String display()
        {
            return "Faculty's Informattion: " + " department : " + department + " , " + "salary :" + salary + "VND" +" , "+ "officehour : " + officehour + " , " + "rank : " + rank;
        }

        public override void CalculateBonus()
        {
            Console.WriteLine(name + " Bonus : " + (salary * 0.05 + 1000) + "VND");
        }

        public override void CalculateVacation()
        {
            if(officehour >= 3)
            {
                week = week + 5;
            };
            if ( rank == "Senlor Lecturer")
            {
                week = week + 1;
            }
            else
            {
                week = week + 4;

            }
            Console.WriteLine("This faculty have " + "" + week + " " + "vacation week");
        }

    }
}

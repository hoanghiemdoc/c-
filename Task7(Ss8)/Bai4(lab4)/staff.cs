using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_lab4_
{
    class staff : Employee
    {
        public string title, dates;
        public staff(string department, double salary, string name, string clas, string phone, string address,  string email, int officehour, string title, string dates) : base(department, salary, name,clas, phone, address,email ,officehour)
        {
            this.title = title;
            this.dates = dates;
        }

        public String display()
        {
            return "Staff's Informattion : "+ " department : " + department + " ," + "salary :" + salary + "VND" + " , "+ "officehour :" + officehour + " , " + "title :" + title + " , " + "dates :" + dates;
        }

        public override void CalculateBonus()
        {
            Console.WriteLine(name + " Bonus : " + (salary * 0.06 + 1000));
        }

        public override void CalculateVacation()
        {
           if(officehour == 5)
            {
                Console.WriteLine("This faculty have 4 vacation week");
            }
           else
            {
                Console.WriteLine("This faculty have 3 vaction week");
            }
        }
    }
}

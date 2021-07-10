using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_lab4_
{
   abstract class   Employee : Person
    {
        public string department;
        public double salary;
        public int officehour;

        public Employee(string department, double salary, string name, string clas, string phone , string address,string email, int officehour):base(name,phone,address,email,clas)
        {
            this.department = department;
            this.salary = salary;
            this.officehour = officehour;
            
        }

        protected Employee(string department, double salary, string name, string phone, string address, string email, int officehour, string clas)
        {
            this.department = department;
            this.salary = salary;
            this.name = name;
            this.phone = phone;
            this.address = address;
            this.email = email;
            this.officehour = officehour;
            this.clas = clas;
        }

        public abstract void CalculateBonus();
        public abstract void CalculateVacation();
        
    }
}

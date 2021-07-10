using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_lab4_
{
    class Person
    {
        public string name;
        public string phone;
        public string address;
        public string email;
        public string clas;

        public Person( string name, string phone, string address, string email, string clas)
        {
            this.name = name;
            this.phone = phone;
            this.address = address;
            this.email = email;
            this.clas = clas;
        }

        public Person() { }

        public override string ToString()
        {
            return "Person informattion : "+  " clas :" + clas + " , " + "Name :" + name  + " , "+ "address :"+ address + " , " + "phone :" + phone +  " , " + "email :"+ email;
        }
    }
}

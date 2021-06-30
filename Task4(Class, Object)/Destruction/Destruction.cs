using System;

namespace Destruction
{
    class Destruction
    {
        private int _empld;
        private String _empName;
        private int _age;
        private double _salary;

        Destruction(int id, String name, int age, double sal)
        {
            Console.WriteLine("Construtor for Employee called");
            _empld = id;
            _empName = name;
            _age = age;
            _salary = sal;
        }

        ~Destruction()
        {
            Console.WriteLine("Destructor for Program called");
            Console.Read();
        }
        static void Main(string[] args)
        {
            Destruction Pgr = new Destruction(1, "Hiep", 19, 15000);
            Console.WriteLine("Program ID: " + Pgr._empld);
            Console.WriteLine("Program Name : " + Pgr._empName);
            Console.WriteLine("Program Age : " + Pgr._age);
            Console.WriteLine("Program Salary : " + Pgr._salary);
        }
    }
}


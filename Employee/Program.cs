using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee("hoang", "nguyen", "vietcombank", 0342988890, 2002000);
            Console.WriteLine(e.ToString());
            Console.WriteLine("bouns" + e.Bouns(50));
            Console.ReadLine();
        }
    }
}

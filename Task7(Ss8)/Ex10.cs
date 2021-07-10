using System;

namespace Ex8._10
{
    interface ISet
    {
        void AcceptDetails(int valOne, string valTwo);
    }
    interface IGet
    {
        void Display();
    }
    class Employee : ISet

    {
        int _empId;
        string _empName;

        public void AcceptDetails(int valOne, string valTwo)
        {
            _empId = valOne;
            _empName = valTwo;
        }
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.AcceptDetails(10, "Hiep");
            IGet iget = employee as IGet;

            if(iget != null)
            {
                iget.Display();
            }
            else
            {
                Console.WriteLine("Invalidcasting occurred");
            }
        }
    }
}

using System;

namespace StudentDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentDetails studentDetails = new StudentDetails();
            Console.WriteLine($"Student name: {studentDetails.studName}");
            Console.WriteLine($"Roll number: {studentDetails.rollNumber}");
            Sum sum = new Sum();
            sum.Add(2, 3);
            Book objBook = new Book();
            objBook.Input("C#-The Complete Reference");
            Console.WriteLine(objBook.Print());

            Student student = new Student();
            /*Passing argument by position*/
            student.printName("Henry", "Parker");
            /*Passing named argument*/
            student.printName(firstName: "Henry", lastName: "Parker");
            student.printName(lastName: "Parker", firstName: "Henry");
            /*Passing named argument after positional argument*/
            student.printName("Henry", lastName: "Parker");

            TestProgram objTest = new TestProgram();
            objTest.Count(boys: 16, girls: 24);


            OptionalParameterExample opExample = new
OptionalParameterExample();
            opExample.printMessage("Welcome User!");
            opExample.printMessage();


            Product.Display();

            Calculate.Addition(10, 50);
            Calculate objCal = new Calculate();
            objCal.Multiply(10, 20);



        }

    }
}

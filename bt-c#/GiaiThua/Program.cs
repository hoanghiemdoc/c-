using System;

namespace GiaiThua
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("so giai thua can tim la");
            Console.WriteLine("---------------------");

            int num, i, f = 1;

            Console.Write("nhap so giai thua la: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= num; i++)
                f = f * i;
            Console.Write("cac so giai thu {0} is: {1}\n", num,f);


            //int i, f = 1, num;

            //Console.Write("\n\n");
            //Console.Write("Calculate the factorial of a given number:\n");
            //Console.Write("--------------------------------------------");
            //Console.Write("\n\n");

            //Console.Write("Input the number : ");
            //num = Convert.ToInt32(Console.ReadLine());
            //for (i = 1; i <= num; i++)
            //    f = f * i;

            //Console.Write("The Factorial of {0} is: {1}\n", num, f);
        }
    }
}

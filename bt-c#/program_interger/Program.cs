using System;

namespace program_interger
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1,num2,num3;
            Console.WriteLine("tim so nguyen lon nhat la");
            Console.Write("--------------------------------");

            Console.Write("nhap so nguyen dau tien la");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("nhap so nguyen thu hai la");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("nhap so nguyen thu ba la");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("so thu nhat la so lon nhat");
                }
                else
                {
                    Console.Write("so thu ba la so lon nhat");
                }
            }
            else if (num2 > num3)
            {
                Console.Write("so thu hai la so lon nhat");

            }
            else 
                Console.Write("so thu ba la so lon nhat");
             if (num3 == num2 || num2 == num1) {
                Console.Write("sai dk roi");
            }
            
        }
         
    }
}

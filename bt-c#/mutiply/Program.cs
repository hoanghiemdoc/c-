using System;

namespace mutiply
{
    class Program
    {
        static void Main(string[] args)
        {
           
            {
                int j, n;
                Console.Write("nhp mot so trong bang cuu chuong la:");
                Console.WriteLine("----------------------------");

                Console.WriteLine("nhap 1 so de in ra bang cuu chuong la: ");
                n = Convert.ToInt32(Console.ReadLine());

                for( j = 0; j <=10; j++ ) {
                    Console.WriteLine("{0}*{1} = {2}",n,j, j * n);
                }
            }
        }
    }
}

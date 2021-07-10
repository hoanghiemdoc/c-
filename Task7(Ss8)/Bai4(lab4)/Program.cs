
using System;

namespace Bai4_lab4_
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Sv = new Student("FPTaptech", "NGUYEN MINH HIEP", "T2010A", "HA NAM", "0702096624", "Hiepminh2605@gmail.com");
            Console.WriteLine(Sv.display());
            Console.WriteLine(Sv.ToString());

            Console.WriteLine("");

            faculty khoa = new faculty("FPTaptech", 25000000, "DANG KIM THI","T2010A", "0134568999","HA NOI" ,"kimthidang@gmail.com", 5,  "Senlor Lecturer", "8h00 - 17h00");
            Console.WriteLine(khoa.display());
            Console.WriteLine(khoa.ToString());
            khoa.CalculateBonus();
            khoa.CalculateVacation();

            Console.WriteLine(""); 

            staff Nv = new staff("FPTaptech", 7000000, "Nhan Vien", "T2010A", "0344047379", "HA NOI", "nhanvien@gmail.com", 5, "Conghien", "26-5-2002");
            Console.WriteLine(Nv.display());
            Console.WriteLine(Nv.ToString());
            Nv.CalculateBonus();
            Nv.CalculateVacation();

            
            Console.ReadLine();

        }
    }
}

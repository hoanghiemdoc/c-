using System;

namespace Automatic_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            Atom at1 = new Atom();
            Console.WriteLine("Atomic infomation");
            Console.WriteLine("-----------------------");
            Console.WriteLine("enter atomic fullName");
            at1.atomfn = Console.ReadLine();
            Console.WriteLine("enter atomic symbol");
            at1.atomsb = Console.ReadLine();
            Console.WriteLine("enter automatic number");
            at1.atomb = int.Parse(Console.ReadLine());
            Console.WriteLine("enter automatic weight");
            at1.atomw = float.Parse(Console.ReadLine());


            Console.WriteLine("-----------------------------------------");
            at1.display();
            Console.ReadLine();
        }
    }
}

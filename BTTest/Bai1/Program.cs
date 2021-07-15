
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Issues with Non-Generic Collections *****\n");
            UsePersonCollection();
            Console.WriteLine();
            UseGenericList();

            Console.WriteLine();
            WorkWithArrayList();

            Console.WriteLine();
            ArrayListOfRandomOjects();
            Console.ReadLine();
        }

        private static void SimpleBoxUnboxOperation()
        {
            // Make a int value type;
            int myInt = 25;

            // Box the int into an object reference.
            object boxedInt = myInt;

            //Unbox int he wrong data type to trigger
            // runtime exception.

            try
            {
                long unboxedInt = (long)boxedInt;
            }
            catch(InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        static void WorkWithArrayList()
        {
            // Value types are automatically boxed when
            // passed to a member requesting an object.

            ArrayList myInts = new ArrayList();
            myInts.Add(10);
            myInts.Add(20);
            myInts.Add(35);
            Console.ReadLine();
        }

        static void ArrayListOfRandomOjects()
        {
            // The ArrayList can hold anything at all.
            ArrayList allMyOjects = new ArrayList();
            allMyOjects.Add(true);
            allMyOjects.Add(new OperatingSystem(PlatformID.MacOSX, new Version(10, 0)));
            allMyOjects.Add(66);
            allMyOjects.Add(3.14);
            Console.ReadLine();
        }

        static void UsePersonCollection()
        {
            Console.WriteLine("***** Custom Person Collection *****\n");
            PersonCollection myPeople = new PersonCollection();
            myPeople.AddPerson(new Person("Homer", "Simpson", 40));
            myPeople.AddPerson(new Person("Marge", "Simpson", 38));
            myPeople.AddPerson(new Person("Minh", "Hiep", 19));
            myPeople.AddPerson(new Person("Ngo", "Dat", 19));
            myPeople.AddPerson(new Person("Chu", "Long", 21));

            //This would be a compile-time error!
            //myPeople.AddPerson(new Car());

            foreach (Person p in myPeople)
                Console.WriteLine(p);

            
        }


        static void UseGenericList()
        {
            Console.WriteLine("***** Fun with Generics *****\n");
            // This List<> can only hold Person object.
            List<Person> morePeople = new List<Person>();
            morePeople.Add(new Person("Frank", "Black", 50));
            Console.WriteLine(morePeople[0]);

            //This List<> can only hold numeric data.
            List<int> moreInts = new List<int>();
            moreInts.Add(10);
            moreInts.Add(2);
            int sum = moreInts[0] + moreInts[1];
            Console.WriteLine("sum : " + sum);

            // Compile-time error! Can't add Person object
            //to a list of ints!
            //moreInts.Add(new Person());

            Console.ReadLine();
        }

    }
}

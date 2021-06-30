using System;

namespace instantiating
{
    class instantiating
    {
        static void Main(string[] args)
        {
            House londonHouse =
                new House { HouseName = "London street", Members = 3 };

            Console.WriteLine("House Name: {0} , Members: {1}",
                londonHouse.HouseName, londonHouse.Members);
        }
    }
}

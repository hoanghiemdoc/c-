using System;

namespace Anonymous_Type
{
    class Program
    {
         /*static void Main(string[] args)
        {
            var stock = new { Name = "Michagan Enterpriess", Code = 1301, Price = 3506.3 };
            Console.WriteLine("Stock Name:" + stock.Name);
            Console.WriteLine("Stock Code:" + stock.Code);
            Console.WriteLine("Stock Price:" + stock.Price);
            Console.Read();
        }*/
        public static void Main(string[] args)
        {
            Employee david = new Employee();
            david.DisplayDetails(new { FirstName = "Daivd", LastName = "Blake", Age = 30 });
            Console.Read();
        }
    }
}


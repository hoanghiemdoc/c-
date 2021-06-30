using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Method objBook = new Method();
            objBook.Input("C#- The Complete Reference");
            Console.WriteLine(objBook.Print());
        }
    }
}

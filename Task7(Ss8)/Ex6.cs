using System;

namespace Ex8._6
{
    interface ITerAnimal
    {
        string Eat();
    }
    interface IMarAnimal
    {
        string Eat();
    }
    class Crocodile : ITerAnimal, IMarAnimal

    {
        string ITerAnimal.Eat()
        {
            string terCroc = "Crocodile eats other animal";
            return terCroc;
        }
        string IMarAnimal.Eat()
        {
            string marCroc = "Crocodile eats fish and marine animals";
            return marCroc;
        }

        public string EatTer()
        {
            ITerAnimal terAnimal;
            terAnimal = this;
            return terAnimal.Eat();
        }

        public string EatMar()
        {
            IMarAnimal marAnimal;
            marAnimal = this;
            return marAnimal.Eat();
        }
        static void Main(string[] args)
        {
            Crocodile crocodile = new Crocodile();
            string terCroc = crocodile.EatTer();
            Console.WriteLine(terCroc);
            string marCroc = crocodile.EatMar();
            Console.WriteLine(marCroc);
        }
    }
}

using System;

namespace Ex8._9
{
    interface ICalculate
    {
        double Area();
    }

    class Rectangle : ICalculate
    {
        float _length;
        float _breadth;

        public Rectangle(float valOne, float valTwo)
        {
            _length = valOne;
            _breadth = valTwo;
        }

        public double Area()
        {
            return _length * _breadth;
        }
        static void Main(string[] args)
        {

            Rectangle rectangle = new Rectangle(10.2F, 20.3F);
            if (rectangle is ICalculate)
            {
                Console.WriteLine("Area of rectangle : {0:F2} ", rectangle.Area());
            }
            else
            {
                Console.WriteLine("Interface method not implemented");
            }
        }
    }
    
      
    
}

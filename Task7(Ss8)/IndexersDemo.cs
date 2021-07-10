
using System;

namespace Ex1._2_lab4_
{
    class IndexerExample
    {
        public int[] intList = new int[10];
        public int this[int index]
        {
            get { return intList[index]; }
            set { intList[index] = value; }
        }
    }
    class IndexerDemo
    {
      
        static void Main(string[] args)
        {
            int i, j = 0;
            IndexerExample indextest = new IndexerExample();
            for (i = 1; i < 20; i += 2)
            {
                indextest[j] = i;
                j++;
            }
            for (i =0; i < 10; i++)
            {
                Console.WriteLine("indexTest [{0}] is {1} ", i, indextest[i]);
                Console.WriteLine();
            }
        }
    }
}

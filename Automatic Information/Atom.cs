using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatic_Information
{
    class Atom
    {
        public int atomb;
        public string atomsb;
        public string atomfn;
        public float atomw ;

        public Atom(int atomb,string atomsb,string atomfn,float atomw)
        {
            this.atomfn = atomfn;
            this.atomsb = atomsb;
            this.atomb = atomb;
            this.atomw = atomw;
        }

        public Atom() { }

        public void display()
        {
            Console.WriteLine("{0}\t\t{1}\t{2}\t{3}", atomw, atomfn, atomb, atomb);
        }


    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class PersonCollection : IEnumerable

    {
        private ArrayList arPeople = new ArrayList();

        //Cast for caller.
        public Person GetPerson(int pos) => (Person)arPeople[pos];

        //Only insert Person types.
        public void AddPerson(Person p)
        {
            arPeople.Add(p);
        }

        public void ClearPeople()
        {
            arPeople.Clear();
        }   

        public int Count => arPeople.Count;

        // Foreach enumeration support.
        IEnumerator IEnumerable.GetEnumerator() => arPeople.GetEnumerator();
    }
}

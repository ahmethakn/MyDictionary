using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyList<A>
    {
        A[] units;
        public MyList()
        {
            units = new A[0];
        }
        public void Add(A unit)
        {
            A[] tempArray = units;
            units = new A[units.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                units[i] = tempArray[i];
            }
            units[units.Length - 1] = unit;
        }
        public A[] Units
        {
            get { return units; }
        }
    }
}

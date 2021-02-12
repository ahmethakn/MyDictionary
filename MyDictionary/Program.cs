using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> unit = new MyList<int>();
            unit.Add(1);
            unit.Add(2);
            foreach (var items in unit.Units)
            {
                Console.WriteLine(items);
            }
        }
    }
}

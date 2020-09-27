using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace akademia7zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> _List = new List<int>() {1,5,6,7,8,9};
            var _List1 = _List.Where(_Element => _Element % 2 == 0).ToList();
            foreach (var item in _List1)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.strategy;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberList = new List<int>
            {
                5,
                7,
                1,
                2,
                3,
                99
            };

            var sort = new SortClass(new SortAsc(), numberList);
            var result = sort.Sort();

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}

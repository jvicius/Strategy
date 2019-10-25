using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.strategy
{
    public class SortDesc : ISortStrategy
    {
        public List<int> SortList(List<int> numberList)
        {
            numberList.Sort();
            numberList.Reverse();
            return numberList;
        }
    }
}

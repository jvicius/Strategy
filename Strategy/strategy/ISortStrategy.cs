using System.Collections.Generic;

namespace Strategy.strategy
{
    public interface ISortStrategy
    {
        List<int> SortList(List<int> numberList);
    }
}
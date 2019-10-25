using System.Collections.Generic;

namespace Strategy.strategy
{
    public class SortClass
    {
        private readonly ISortStrategy _strategy;
        private readonly List<int> _numberList;

        public SortClass(ISortStrategy strategy, List<int> numberList)
        {
            _strategy = strategy;
            _numberList = numberList;
        }

        public List<int> Sort()
        {
            return (_numberList==null)? new List<int>() : _strategy.SortList(_numberList);
        }
    }
}
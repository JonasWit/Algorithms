using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    public class QuickSort<TArr> : SortBase<TArr> where TArr : IComparable
    {
        private int _mutation = 0;
        public void Sort(TArr[] array)
        {
            Sort(array, 0, array.Length - 1);
        }

        private TArr[] Sort(TArr[] array, int lower, int upper)
        {
            if (lower < upper)
            {
                var p = Partition(array, lower, upper);
                Sort(array, lower, p);
                Sort(array, p + 1, upper);
            }
            return array;
        }

        private int Partition(TArr[] array, int lower, int upper)
        {
            var i = lower;
            var j = upper;

            TArr pivot = array[lower];
            do
            {
                while (array[i].CompareTo(pivot) < 0) { i++; }
                while (array[j].CompareTo(pivot) > 0) { j--; }
                if (i >= j) { break; }
                Swap(array, i, j);
                OnMutationEventReached(new ArrayPayload<TArr>() { Arr = array, Mutation = _mutation++ });
            } while (i <= j);
            return j;
        }
    }
}

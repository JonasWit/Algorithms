using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Algorithms.Sorting
{
    public class Insertionsort<TArr> : SortBase<TArr> where TArr : IComparable
    {
        public void Sort(TArr[] array)
        {
            int mutation = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int j = i;
                while (j > 0 && array[j].CompareTo(array[j - 1]) < 0)
                {
                    Swap(array, j, j - 1);
                    j--;
                    OnMutationEventReached(new ArrayPayload<TArr>() { Arr = array, Mutation = mutation++ });
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    public class BubbleSort<TArr> : SortBase<TArr> where TArr : IComparable
    {
        public void Sort(TArr[] array)
        {
            int mutation = 0;
            for (int i = 0; i < array.Length; i++)
            {
                var isAnyChange = false;
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) < 0)
                    {
                        isAnyChange = true;
                        Swap(array, j, j + 1);
                        OnMutationEventReached(new ArrayPayload<TArr>() { Arr = array, Mutation = mutation++ });
                    }
                }
                if (!isAnyChange)
                {
                    break;
                }
            }
        }
    }
}

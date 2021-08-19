using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Algorithms.Sorting
{
    public class SelectionSort<TArr> : SortBase<TArr> where TArr : IComparable
    {
        public void Sort(TArr[] array) 
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            int mutation = 0;

            for (int i = 0; i < array.Length; i++)
            {
                var minIndex = i;
                TArr minValue = array[i];
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j].CompareTo(minValue) < 0)
                    {
                        minIndex = j;
                        minValue = array[j];
                    }
                }
                Swap(array, i, minIndex);
                OnMutationEventReached(new ArrayPayload<TArr>() { Arr = array, Mutation = mutation++});
            }

            stopwatch.Stop();
            OnBenchmarkEventReached(new TimeSpanPayload() { ElapsedMiliseconds = stopwatch.ElapsedMilliseconds });
        }
    }
}

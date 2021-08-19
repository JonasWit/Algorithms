using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    public abstract class SortBase<TArr>
    {
        public event EventHandler<ArrayPayload<TArr>> MutationEvent;
        public event EventHandler<TimeSpanPayload> BenchmarkEvent;

        protected void Swap<T>(T[] array, int first, int second)
        {
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }

        protected virtual void OnMutationEventReached(ArrayPayload<TArr> e) => MutationEvent?.Invoke(this, e);
        protected virtual void OnBenchmarkEventReached(TimeSpanPayload e) => BenchmarkEvent?.Invoke(this, e);
    }
}

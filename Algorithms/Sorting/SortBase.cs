using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public void Benchmark(Action sortMethod)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            sortMethod.Invoke();
            stopwatch.Stop();
            OnBenchmarkEventReached(new TimeSpanPayload() { ElapsedMiliseconds = stopwatch.ElapsedMilliseconds });
        }

        protected virtual void OnMutationEventReached(ArrayPayload<TArr> e) => MutationEvent?.Invoke(this, e);
        protected virtual void OnBenchmarkEventReached(TimeSpanPayload e) => BenchmarkEvent?.Invoke(this, e);
    }
}

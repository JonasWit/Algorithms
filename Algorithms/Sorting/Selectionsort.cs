using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    public class SelectionSort<TArr> where TArr : IComparable
    {
        public event EventHandler<ArrayPayload<TArr>> EmitEvent;

        public void Sort(TArr[] array) 
        {
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
                OnEventReached(new ArrayPayload<TArr>() { Arr = array});
            }
        }

        private void Swap<T>(T[] array, int first, int second)
        {
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }

        protected virtual void OnEventReached(ArrayPayload<TArr> e) => EmitEvent?.Invoke(this, e);
    }
}

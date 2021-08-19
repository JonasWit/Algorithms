using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class ArrayPayload<T> : EventArgs
    {
        public int Mutation;
        public T[] Arr;
    }

    public class TimeSpanPayload : EventArgs
    {
        public long ElapsedMiliseconds;
    }
}

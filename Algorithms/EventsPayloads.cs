using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class ArrayPayload<T> : EventArgs
    {
        public T[] Arr;
    }
}

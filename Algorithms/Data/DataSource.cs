using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Data
{
    public static class DataSource
    {
        public static int[] IntArray = {-42, 12, 16, -11, -9, 0, 1, 6, 12, 68, 90};
        public static string[] StringArray = { "Maria", "Marcin", "Anna", "Jakub", "Jerzy", "Nikola" };

        public static int[] IntListRandom()
        {
            Random rnd = new Random();
            return Enumerable.Range(1, 100).OrderBy(_ => rnd.Next()).ToArray();
        }
    }
}

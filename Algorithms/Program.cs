using Algorithms.Data;
using Algorithms.Sorting;
using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Input test numer: ");
                var testName = Console.ReadLine();

                switch (testName)
                {
                    case "sort":
                        try
                        {
                            Console.WriteLine("Test 1 Started - selection sort on Int");
                            var sortInt = new SelectionSort<int>();
                            sortInt.MutationEvent += TestIntArrayEvent;
                            sortInt.BenchmarkEvent += TestBenchmarkArrayEvent;
                            sortInt.Benchmark(() => sortInt.Sort(DataSource.IntArray));

                            sortInt.MutationEvent -= TestIntArrayEvent;
                            sortInt.BenchmarkEvent -= TestBenchmarkArrayEvent;

                            Console.WriteLine("Test 2 Started - selection sort on String");
                            var sortString = new SelectionSort<string>();
                            sortString.MutationEvent += TestStringArrayEvent;
                            sortString.BenchmarkEvent += TestBenchmarkArrayEvent;
                            sortString.Benchmark(() => sortString.Sort(DataSource.StringArray));

                            sortString.MutationEvent -= TestStringArrayEvent;
                            sortString.BenchmarkEvent -= TestBenchmarkArrayEvent;

                            Console.WriteLine("Test 3 Started - insertion sort on Int");
                            var insInt = new InsertionSort<int>();
                            insInt.MutationEvent += TestIntArrayEvent;
                            insInt.BenchmarkEvent += TestBenchmarkArrayEvent;
                            insInt.Benchmark(() => insInt.Sort(DataSource.IntArray));

                            insInt.MutationEvent -= TestIntArrayEvent;
                            insInt.BenchmarkEvent -= TestBenchmarkArrayEvent;

                            Console.WriteLine("Test 4 Started - bubble sort on Int");
                            var bubInt = new BubbleSort<int>();
                            bubInt.MutationEvent += TestIntArrayEvent;
                            bubInt.BenchmarkEvent += TestBenchmarkArrayEvent;
                            bubInt.Benchmark(() => bubInt.Sort(DataSource.IntArray));

                            bubInt.MutationEvent -= TestIntArrayEvent;
                            bubInt.BenchmarkEvent -= TestBenchmarkArrayEvent;

                            Console.WriteLine("Test 5 Started - quick sort on Int");
                            var qInt = new QuickSort<int>();
                            qInt.MutationEvent += TestIntArrayEvent;
                            qInt.BenchmarkEvent += TestBenchmarkArrayEvent;
                            qInt.Benchmark(() => qInt.Sort(DataSource.IntArray));

                            qInt.MutationEvent -= TestIntArrayEvent;
                            qInt.BenchmarkEvent -= TestBenchmarkArrayEvent;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "selection-sort2":
                        try
                        {
                        



                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Test Finished!");
            }
        }

        static void TestIntArrayEvent(object sender, ArrayPayload<int> e) => 
            Console.WriteLine($"Array mutation {e.Mutation} : {string.Join(", ", e.Arr)}");

        static void TestStringArrayEvent(object sender, ArrayPayload<string> e) => 
            Console.WriteLine($"Array mutation {e.Mutation}: {string.Join(", ", e.Arr)}");

        static void TestBenchmarkArrayEvent(object sender, TimeSpanPayload e) =>
            Console.WriteLine($">>>> Time spent: {e.ElapsedMiliseconds}ms <<<<" + Environment.NewLine);

    }
}

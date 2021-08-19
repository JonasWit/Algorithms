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
                    case "selection-sort":
                        try
                        {
                            Console.WriteLine("Test 1 Started...");
                            var sort = new SelectionSort<int>();
                            sort.EmitEvent += TestIntArrayEvent;
                            sort.Sort(DataSource.IntArray);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            throw;
                        }
                        break;
                    case "selection-sort2":
                        try
                        {
                        
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            throw;
                        }
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Test Finished!");
            }
        }

        static void TestIntArrayEvent(object sender, ArrayPayload<int> e)
        {
            var arr = e as ArrayPayload<int>;
            Console.WriteLine($"Array mutation: {string.Join(", ", arr.Arr)}");
        }
    }
}

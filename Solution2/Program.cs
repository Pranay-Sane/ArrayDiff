using System;
using System.Linq;

namespace Solution2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 11, 23, 83, 41, 95, 36, 77, 81, 90 };
            int[] arr2 = { 11, 33, 88, 41, 77, 8, 4, 10 };
            Console.WriteLine(String.Join(", ", ArrayDiff(arr1, arr2)));
        }

        static T[] ArrayDiff<T>(T[] arr1, T[] arr2)
        {
            return arr1.Where(x => !arr2.Contains(x)).ToArray();
        }
    }
}

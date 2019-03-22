using System;
using System.Linq;

namespace Solution1
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
            var res = arr1.ToList();
            foreach (var item in arr1)
            {
                if(arr2.Contains(item))
                {
                    res.Remove(item);
                }
            }
            return res.ToArray();
        }
    }
}

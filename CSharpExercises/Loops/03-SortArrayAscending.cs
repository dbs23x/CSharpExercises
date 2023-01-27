using System.ComponentModel;
using System;

namespace CSharpExercises.Loops
{

    //Sort array ascending
    //Given an array of integers, write a method that returns sorted array in ascending order.
    //Expected input and output
    //SortArrayAscending([9, 5, 7, 2, 1, 8]) →  [1, 2, 5, 7, 8, 9]

    public class _03_SortArrayAscending
    {
        static int[] SortArrayAscending(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            return arr;
        }

        static void Main(string[] args)
        {
            int[] sortedArr = SortArrayAscending(new int[] { 0, -23, 9, 18, -51, 1, 90, 57, -1, 25 });

            foreach (var s in sortedArr)
            {
                Console.Write($"{s} "); // -51 -23 -1 0 1 9 18 25 57 90
            }
        }
    }
}
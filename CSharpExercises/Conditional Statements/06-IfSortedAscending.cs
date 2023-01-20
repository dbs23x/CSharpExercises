using System.Threading;
using System;

namespace CSharpExercises.Conditional_Statements
{

    //If sorted ascending
    //Given an array of three integers, write a method that checks if they are sorted in ascending order.
    //Expected input and output
    //IfSortedAscending([3, 7, 10])→ true
    //IfSortedAscending([74, 62, 99])→ false

    public class _06_IfSortedAscending
    {
        static bool IfSortedAscending(int[] arr)
        {
            return arr[0] <= arr[1] && arr[1] <= arr[2];
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IfSortedAscending(new int[] { 3, 6, 9 })); // True
            Console.WriteLine(IfSortedAscending(new int[] { 34, 17, 90 })); // False
            Console.WriteLine(IfSortedAscending(new int[] { -50, -24, -1 })); // True
        }
    }
}
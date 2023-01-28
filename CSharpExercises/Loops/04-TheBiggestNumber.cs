using System.ComponentModel;
using System;

namespace CSharpExercises.Loops
{

    //The biggest number
    //Given an array of integers, write a method that returns the biggest number in this array.
    //Expected input and output
    //TheBiggestNumber([190, 291, 145, 209, 280, 300]) → 291
    //TheBiggestNumber([-9, -2, -7, -8, -4]) → -2

    public class _04_TheBiggestNumber
    {
        static int TheBiggestNumber(int[] numArr)
        {
            int theBiggest = numArr[0];

            for (int i = 1; i < numArr.Length; i++)
            {
                if (numArr[i] > theBiggest)
                {
                    theBiggest = numArr[i];
                }
            }

            return theBiggest;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(TheBiggestNumber(new int[] { 9, 4, 8, 1, 0, 2 }));                   // 9
            Console.WriteLine(TheBiggestNumber(new int[] { -34, -54, -7, -40, -123, -99 }));       // -7
            Console.WriteLine(TheBiggestNumber(new int[] { 1009, 998, 1090, 3000, 2934, 4888 }));  // 4888
        }
    }
}
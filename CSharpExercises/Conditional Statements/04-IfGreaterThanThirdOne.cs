using System.ComponentModel;
using System;

namespace CSharpExercises.Conditional_Statements
{

    //If greater than third one
    //Given an array of 3 integers, write a method that checks if multiplication or sum of two first numbers is greater than third one.
    //Expected input and output
    //IfGreaterThanThirdOne([2, 7, 12]) → true
    //IfGreaterThanThirdOne([-5, -8, 50]) → false

    public class _04_IfGreaterThanThirdOne
    {
        static bool IfGreaterThanThirdOne(int[] arr)
        {
            return arr[0] + arr[1] > arr[2] || arr[0] * arr[1] > arr[2];
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IfGreaterThanThirdOne(new int[] { 2, 8, 20 }));      // False
            Console.WriteLine(IfGreaterThanThirdOne(new int[] { 10, 5, 22 }));     // True
            Console.WriteLine(IfGreaterThanThirdOne(new int[] { -15, -25, 100 })); // True
            Console.WriteLine(IfGreaterThanThirdOne(new int[] { 11, 15, 166 }));   // False
        }
    }
}
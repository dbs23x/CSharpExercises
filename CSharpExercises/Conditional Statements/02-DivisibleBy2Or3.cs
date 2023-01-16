using System.ComponentModel;

namespace CSharpExercises.Conditional_Statements
{

    //Divisible by 2 or 3
    //Given two integers, write a method that returns their multiplication if they are both divisible by 2 or 3, otherwise returns thier sum.
    //Expected input and output
    //DivisibleBy2Or3(15, 30) → 450
    //DivisibleBy2Or3(2, 90) → 180
    //DivisibleBy2Or3(7, 12) → 19

    public class _02_DivisibleBy2Or3
    {
        class DivisibleBy2Or3Task
        {
            static int DivisibleBy2Or3(int a, int b)
            {
                return (a % 2 == 0 && b % 2 == 0 || a % 3 == 0 && b % 3 == 0) ? a * b : a + b;
            }

            static void Main(string[] args)
            {
                Console.WriteLine(DivisibleBy2Or3(2, 18));   // 36
                Console.WriteLine(DivisibleBy2Or3(7, 0));    // 7
                Console.WriteLine(DivisibleBy2Or3(33, 9));   // 297
                Console.WriteLine(DivisibleBy2Or3(-72, 54)); // -3888
                Console.WriteLine(DivisibleBy2Or3(24, -80)); // -1920
                Console.WriteLine(DivisibleBy2Or3(444, 0));  // 0
            }
        }
    }
}
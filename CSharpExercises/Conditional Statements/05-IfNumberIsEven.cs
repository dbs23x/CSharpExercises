using System.ComponentModel;

namespace CSharpExercises.Conditional_Statements
{

    //If number is even
    //Given an integer, write a method that checks if it is even.
    //Expected input and output
    //IfNumberIsEven(721) → false
    //IfNumberIsEven(1248) → true

    public class _05_IfNumberIsEven
    {
        static bool IfNumberIsEven(int num)
        {
            return num % 2 == 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IfNumberIsEven(8));          // True
            Console.WriteLine(IfNumberIsEven(54749));      // False
            Console.WriteLine(IfNumberIsEven(-43234670));  // True
            Console.WriteLine(IfNumberIsEven(0));          // True
            Console.WriteLine(IfNumberIsEven(-950541901)); // False
            Console.WriteLine(IfNumberIsEven(2140872324)); // True
        }
    }
}
using System.ComponentModel;

namespace CSharpExercises.Conditional_Statements
{

    //Positive, negative or zero
    //Given a number, write a method that checks if it is positive, negative or zero.
    //Expected input and output
    //PositiveNegativeOrZero(5.24) → positive
    //PositiveNegativeOrZero(0.0) → zero
    //PositiveNegativeOrZero(-994.53) → negative

    public class _08_PositiveNegativeOrZero
    {
        static string PositiveNegativeOrZero(double num)
        {
            if (num > 0.0)
            {
                return "Positive";
            }
            else if (num < 0.0)
            {
                return "Negative";
            }

            return "Zero";
        }

        static void Main(string[] args)
        {
            Console.WriteLine(PositiveNegativeOrZero(3.14)); // Positive
            Console.WriteLine(PositiveNegativeOrZero(0.0)); // Zero
            Console.WriteLine(PositiveNegativeOrZero(-200.003)); // Negative
        }
    }
}
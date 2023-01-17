using System.ComponentModel;

namespace CSharpExercises.Conditional_Statements
{

    //If consists of uppercase letters
    //Given a 3 characters long string, write a method that checks if it consists only of uppercase letters.
    //Expected input and output
    //IfConsistsOfUppercaseLetters("xyz") → false
    //IfConsistsOfUppercaseLetters("DOG") → true
    //IfConsistsOfUppercaseLetters("L9#") → false

    public class _03_IfConsistsOfUppercaseLetters
    {
        static bool IfConsistsOfUppercaseLetters(string str)
        {
            return (str[0] >= 65 && str[1] >= 65 && str[2] >= 65) && (str[0] <= 90 && str[1] <= 90 && str[2] <= 90);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IfConsistsOfUppercaseLetters("drY")); // False 
            Console.WriteLine(IfConsistsOfUppercaseLetters("LOL")); // True
            Console.WriteLine(IfConsistsOfUppercaseLetters("N0t")); // False
            Console.WriteLine(IfConsistsOfUppercaseLetters("$1r")); // False
        }
    }
}
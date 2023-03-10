namespace CSharpExercises.Conditional_Statements
{

    //If year is leap
    //Given a year as integer, write a method that checks if year is leap.
    //Expected input and output
    //IfYearIsLeap(2016) → true
    //IfYearIsLeap(2018) → false

    public class _09_IfYearIsLeap
    {
        static bool IfYearIsLeap(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IfYearIsLeap(2020)); // True
            Console.WriteLine(IfYearIsLeap(1719)); // False
            Console.WriteLine(IfYearIsLeap(2000)); // True
            Console.WriteLine(IfYearIsLeap(1412)); // True
            Console.WriteLine(IfYearIsLeap(1582)); // False
        }
    }
}
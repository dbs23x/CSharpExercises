namespace CSharpExercises.Conditional_Statements
{

    //Absolute value
    //Given an integer, write a method that returns its absolute value.
    //Expected input and output
    //AbsoluteValue(6832) → 6832
    //AbsoluteValue(-392) → 392

    public class _01_AbsoluteValue
    {
        static int AbsoluteValue(int number)
        {
            return number >= 0 ? number : number * -1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(AbsoluteValue(-690543));  // 690543
            Console.WriteLine(AbsoluteValue(2744));     // 2744
            Console.WriteLine(AbsoluteValue(0));        // 0           
            Console.WriteLine(AbsoluteValue(-23));      // 23
        }
    }
}
namespace CSharpExercises.Basics
{

    //Swap two numbers
    //Given two integers, write a method that swaps them using temporary variable.
    //Expected input and output
    //SwapTwoNumbers(87, 45) → "Before: a = 87, b = 45; After: a = 45, b = 87"
    //SwapTwoNumbers(-13, 2) → "Before: a = -13, b = 2; After: a = 2, b = -13"
    public class _07_SwapTwoNumbers
    {
        public static string SwapTwoNumbers(int a, int b)
        {
            string before = $"Before: a = {a}, b = {b}; ";
            int temp;

            temp = b;
            b = a;
            a = temp;

            string after = $"After: a = {a}, b = {b}";
            return before + after;
        }

        public static void Main()
        {
            Console.WriteLine(SwapTwoNumbers(23, 15));      // Before: a = 23, b = 15; After: a = 15, b = 23
            Console.WriteLine(SwapTwoNumbers(-123, 999));   // Before: a = -123, b = 999; After: a = 999, b = -123
            Console.WriteLine(SwapTwoNumbers(0, 333));      // Before: a = 0, b = 333; After: a = 333, b = 0
        }
    }
}

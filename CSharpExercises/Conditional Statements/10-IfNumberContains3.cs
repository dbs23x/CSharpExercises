namespace CSharpExercises.Conditional_Statements
{
    //If number contains 3
    //Write a method that checks if given number(positive integer) contains digit 3. Do not convert number to other type.Do not use built-in functions like Contains(), StartsWith(), etc.
    //Expected input and output
    //IfNumberContains3(7201432) → true
    //IfNumberContains3(87501) → false

    public class _10_IfNumberContains3
    {
        public static bool IfNumberContains3(int number)
        {
            while (number > 0)
            {
                if (number % 10 == 3)
                {
                    return true;
                }

                number /= 10;
            }

            return false;
        }

        public static void Main()
        {
            Console.WriteLine(IfNumberContains3(5384562)); // true
            Console.WriteLine(IfNumberContains3(0));       // false
            Console.WriteLine(IfNumberContains3(390462));  // true
        }
    }
}
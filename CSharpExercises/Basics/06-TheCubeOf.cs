namespace CSharpExercises.Basics
{
    //The cube of
    //Given a number, write a method that returns its cube.
    //Expected input and output
    //TheCubeOf(2) → 8
    //TheCubeOf(-5.5) → -166.375

    public class _06_TheCubeOf
    {
        public static double TheCubeOf(double num)
        {
            return num * num * num;
        }

        public static void Main()
        {
            Console.WriteLine(TheCubeOf(15));    // 3375
            Console.WriteLine(TheCubeOf(0.25));  // 0.015625
            Console.WriteLine(TheCubeOf(-12));   // -1728
            Console.WriteLine(TheCubeOf(-0.1));  // -0.001
        }
    }
}
namespace CSharpExercises.Basics
{
    //Modulo operations
    //Given three integers, write a method that returns first number divided modulo by second one and these divided modulo by third one.
    //Expected input and output
    //ModuloOperations(8, 5, 2) → 1

    public class _05_ModuloOperations
    {
        public static int ModuloOperations(int a, int b, int c)
        {
            return a % b % c;
        }

        public static void Main()
        {
            Console.WriteLine(ModuloOperations(542, 28, 7));    // 3
            Console.WriteLine(ModuloOperations(33, 10, 2));     // 1
            Console.WriteLine(ModuloOperations(2634, 892, 55)); // 25
        }
    }
}
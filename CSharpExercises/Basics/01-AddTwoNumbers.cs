namespace CSharpExercises.Basics
{
    //Add two numbers
    //Given three numbers, write a method that adds two first ones and multiplies them by a third one.
    //Expected input and output
    //AddAndMultiply(2, 4, 5) → 30

    public class AddTwoNumbers
    {
        public double AddAndMultiply(double a, double b, double c)
        {
            return (a + b) * c;
        }

        public void Main()
        {
            Console.WriteLine(AddAndMultiply(3, 6, 35));        // 315
            Console.WriteLine(AddAndMultiply(-12, 5, 17));      // -119
            Console.WriteLine(AddAndMultiply(-40, 50, 60));     // 600
            Console.WriteLine(AddAndMultiply(1.7, 9.9, 0.01));  // 0.116
        }
    }
}

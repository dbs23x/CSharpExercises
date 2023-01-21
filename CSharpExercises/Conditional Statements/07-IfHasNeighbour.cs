namespace CSharpExercises.Conditional_Statements
{

    //If has neighbour
    //Given three letter long string, write a method that checks if at least one neighbour of middle letter is its neighbour in the alphabet.
    //Expected input and output
    //IsLonelyIsland("XYZ") → True
    //IsLonelyIsland("GWK") → False

    internal class _07_IfHasNeighbour
    {
        public static bool IfHasNeighbour(string word)
        {
            return word[0] == word[1] - 1 || word[0] == word[1] + 1 || word[2] == word[1] - 1 || word[2] == word[1] + 1;
        }

        public static void Main()
        {
            Console.WriteLine(IfHasNeighbour("DCA")); // True
            Console.WriteLine(IfHasNeighbour("PRT")); // False
        }
    }
}
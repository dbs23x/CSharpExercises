namespace CSharpExercises.Loops
{

    //Two 7s next to each other
    //Given an array of positive digits, write a method that returns number of times that two 7's are next to each other in an array.
    //Expected input and output
    //Two7sNextToEachOther([ 8, 2, 5, 7, 9, 0, 7, 7, 3, 1]) → 1
    //Two7sNextToEachOther([ 9, 4, 5, 3, 7, 7, 7, 3, 2, 5, 7, 7 ]) → 3

    public class _05_Two7sNextToEachOther
    {
        static int Two7sNextToEachOther(int[] arr)
        {
            int adjacent7s = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == 7 && arr[i + 1] == 7)
                {
                    adjacent7s++;
                }
            }

            return adjacent7s;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Two7sNextToEachOther(new int[] { 7, 7, 8, 4, 3, 7, 2, 1, 0, 7 }));           // 1
            Console.WriteLine(Two7sNextToEachOther(new int[] { 4, 7, 8, 2, 0, 5, 2, 7, 5, 8 }));           // 0      
            Console.WriteLine(Two7sNextToEachOther(new int[] { 7, 7, 7, 0, 2, 6, 4, 8, 6, 5, 2, 7, 7 }));  // 3
        }
    }
}
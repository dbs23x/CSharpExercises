namespace CSharpExercises.Loops
{

    //Sieve of Eratosthenes
    //Given an integer n(n>2), write a method that returns prime numbers from range[2, n].
    //Expected input and output
    //SieveOfEratosthenes(30) → [2, 3, 5, 7, 11, 13, 17, 19, 23, 29]

    public class _08_SieveOfEratosthenes
    {
        class SieveOfEratosthenesTask
        {
            static bool[] SieveOfEratosthenes(int n)
            {
                bool[] array = new bool[n];

                for (int i = 2; i < n; i++)
                {
                    array[i] = true;
                }

                for (int j = 2; j * j <= n; j++)
                {
                    if (array[j] == true)
                    {
                        for (int k = j * j; k < n; k += j)
                        {
                            array[k] = false;
                        }
                    }
                }
                return array;
            }

            static void Main(string[] args)
            {
                var arrayOfPrimes = SieveOfEratosthenes(100);
                for (int i = 0; i < arrayOfPrimes.Length; i++)
                {
                    if (arrayOfPrimes[i] != false)
                    {
                        Console.Write($"{i} "); // 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47 53 59 61 67 71 73 79 83 89 97 
                    }
                }
            }
        }
    }
}
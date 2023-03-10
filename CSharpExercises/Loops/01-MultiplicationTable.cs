using System.ComponentModel;

namespace CSharpExercises.Loops
{

    //Multiplication table
    //Write a method that prints 10 by 10 multiplication table.Remember about readibility (spaces in the right place).
    //Expected input and output
    //1  2  3  4  5  6  7  8  9 10
    //2  4  6  8 10 12 14 16 18 20
    //3  6  9 12 15 18 21 24 27 30
    //4  8 12 16 20 24 28 32 36 40
    //5 10 15 20 25 30 35 40 45 50
    //6 12 18 24 30 36 42 48 54 60
    //7 14 21 28 35 42 49 56 63 70
    //8 16 24 32 40 48 56 64 72 80
    //9 18 27 36 45 54 63 72 81 90
    //10 20 30 40 50 60 70 80 90 100

    public class _01_MultiplicationTable
    {
        static void MultiplicationTable()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (i == 1)
                    {
                        if (i * j < 10)
                        {
                            Console.Write($" {i * j} ");
                        }
                        else
                        {
                            Console.Write($"{i * j} ");
                        }
                    }
                    else if (i > 1 && i < 10)
                    {
                        if (i * j < 10)
                        {
                            Console.Write($" {i * j} ");
                        }
                        else
                        {
                            Console.Write($"{i * j} ");
                        }
                    }
                    else
                    {
                        Console.Write($"{i * j} ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            MultiplicationTable();
            // 1  2  3  4  5  6  7  8  9 10
            // 2  4  6  8 10 12 14 16 18 20
            // 3  6  9 12 15 18 21 24 27 30
            // 4  8 12 16 20 24 28 32 36 40
            // 5 10 15 20 25 30 35 40 45 50
            // 6 12 18 24 30 36 42 48 54 60
            // 7 14 21 28 35 42 49 56 63 70
            // 8 16 24 32 40 48 56 64 72 80
            // 9 18 27 36 45 54 63 72 81 90
            //10 20 30 40 50 60 70 80 90 100
        }
    }
}
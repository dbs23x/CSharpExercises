using CSharpExercises.Basics;

Console.WriteLine(@"Menu:
01-AddTwoNumbers
02-CelsiusToFahrenheit
03-ElementaryOperations
04-IsResultTheSame
05-ModuloOperations
06-TheCubeOf
07-SwapTwoNumbers
");

Console.WriteLine("Select: ");
var menu = Convert.ToInt32(Console.ReadLine());

if (menu == 1)
{
    Console.Clear();
    AddTwoNumbers addTwoNumbers = new AddTwoNumbers();
    addTwoNumbers.Main();
}
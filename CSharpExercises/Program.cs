using CSharpExercises.Basics;

Console.WriteLine(@"Menu:
1 - 01-AddTwoNumbers.cs
");

Console.WriteLine("Select: ");
var menu = Convert.ToInt32(Console.ReadLine());

if (menu == 1)
{
    Console.Clear();
    AddTwoNumbers addTwoNumbers = new AddTwoNumbers();
    addTwoNumbers.Main();
}
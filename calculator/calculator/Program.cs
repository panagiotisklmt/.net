using System.Numerics;
using System.Globalization;

Console.WriteLine("Enter the first number:");

double userInt1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Enter the second number:");

double userInt2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double sum = userInt1 + userInt2;

//Console.WriteLine("The sum of " + userInt1 + " and " + userInt2 + " = " + sum);

//string interpolation

Console.WriteLine($"The sum of {userInt1} and {userInt2} = {sum}");

Console.ReadKey();
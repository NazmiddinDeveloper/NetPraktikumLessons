// arifmetik operatorlar
//using System;
Console.Write("please write first number : ");
short firstNumber = (short)Convert.ToInt32(Console.ReadLine());
Console.Write("plese write second number : ");
short secondNumber = (short)Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"adding {firstNumber + secondNumber}");
Console.WriteLine($"substructing {firstNumber - secondNumber}");
Console.WriteLine($"umnojit {firstNumber * secondNumber}");
Console.WriteLine($"delim {firstNumber / secondNumber}");
Console.ReadKey();
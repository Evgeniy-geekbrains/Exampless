// Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.

using static System.Console;

WriteLine ("Введите трехзначное число");
int number = int.Parse(Console.ReadLine()!);

WriteLine ($"Вторая цифра в числе {number/10%10}");
// Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.

using static System.Console;

WriteLine("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine()!);

string numberPosition = Convert.ToString(number);

if (numberPosition.Length > 2)
{
  WriteLine("Третья цифра: " + numberPosition[2]);
}
else
{
  WriteLine("Третьей цифры нет!");
}
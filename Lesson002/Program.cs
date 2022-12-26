using static System.Console;
WriteLine("Введите первое число: ");
int a = int.Parse(ReadLine()!);

WriteLine("Введите второе число: ");
int b = int.Parse(ReadLine()!);
if (a>b) 
{     
    WriteLine("Первое число больше второго"); 
}
else if (a<b) 
{   
    WriteLine("Второе число больше первого");
}
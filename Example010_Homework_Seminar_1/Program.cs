//Задача 1: Напишите программу вычисления модуля числа

/*
Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine());
if (number < 0)
{
    number = -number;
}
Console.WriteLine("Введенное число по модулю: " + number);
*/

//Задача 2: Напишите программу, которая на вход принимает значение, а на выходе показывает обратное значение.
// 1 -> 1   2 -> 0.5     0.25 -> 4


Console.Write("Введите число не равное 0: ");
double number = double.Parse(Console.ReadLine());
if (number != 0)
{
   Console.WriteLine(1/number); 
}
else
{
    Console.WriteLine("Введите число не равное 0");
}




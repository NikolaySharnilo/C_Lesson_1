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

/*
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
*/


// Задача 3: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.Write("Введите первое число: ");
double numberA = double.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
double numberB = double.Parse(Console.ReadLine());

if (numberA >= numberB)
{
    Console.WriteLine("max = " + numberA);
}
else
{
    Console.WriteLine("max = " + numberB);
}
*/


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


Console.Write("Введите первое число: ");
double numberA = double.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
double numberB = double.Parse(Console.ReadLine());

Console.Write("Введите третье число: ");
double numberC = double.Parse(Console.ReadLine());

double max = numberA;

if (max < numberB)
{
    max = numberB;
}

if (max < numberC)
{
    max = numberC;
}

Console.WriteLine("Максимальное число: " + max);

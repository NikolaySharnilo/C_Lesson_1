//Задача 1: Напишите программу вычисления модуля числа


Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine());
if (number < 0)
{
    number = -number;
}
Console.WriteLine("Введенное число по модулю: " + number);



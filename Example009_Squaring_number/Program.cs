//Задча 0: ПРограмма для возмедения в квадрат
/*
Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine());

int result = number * number;

Console.WriteLine(result);
*/

//Задача 1: Программа, которая принимает два числа и проверяет, является ли первое число квадратом второго
/*
Console.Write("Введите первое целое число: ");
int numberA = int.Parse(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int numberB = int.Parse(Console.ReadLine());

if ((numberA*numberA)==numberB) {
    Console.WriteLine("Первое число " + numberA + " является квадратом числа "+ numberB);
}
else
{
    Console.WriteLine("Первое число не является квадртом второго");
}
*/

//Задача 2: Программа для вывода названия дня недели по введенному номеру
/*
Console.Write("Введите число для определения дня недели: ");
int number = int.Parse(Console.ReadLine());

if (number==1)
{
    Console.WriteLine("Понедельник");
}
else if (number==2)
{
    Console.WriteLine("Вторник");
}
else if (number==3)
{
    Console.WriteLine("Среда");
}
else if (number==4)
{
    Console.WriteLine("Четверг");
}
else if (number==5)
{
    Console.WriteLine("Пятница");
}
else if (number==6)
{
    Console.WriteLine("Суббота");
}
else if (number==7)
{
    Console.WriteLine("Воскресенье");
}
else 
{
    Console.WriteLine("Введите корректное число");
}
*/

//Задача 3: Напишите программу вычисления фукнции
/*
Console.Write("Введите число для расчета фукнции: ");
int number = int.Parse(Console.ReadLine());
int result = number * number + number - 1;
Console.WriteLine(result);
*/

//Задача 4: Напишите программу, которая на вход принимает одно число (N), 
//а на выходе показывает все целые числа в промежутке от -N до N

Console.Write("Введите число для расчета фукнции: ");
int numberA = Math.Abs(int.Parse(Console.ReadLine()));
int numberV  = -Math.Abs(numberA);

while (numberV <= numberA)
{
    Console.Write ($"{numberV} ");
    numberV++;
}
Console.WriteLine();


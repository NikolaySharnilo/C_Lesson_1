//ПРограмма для возмедения в квадрат
/*
Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine());

int result = number * number;

Console.WriteLine(result);
*/

//Программа, которая принимает два числа и проверяет, является ли первое число квадратом второго
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

//Программа для вывода названия дня недели по введенному номеру

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
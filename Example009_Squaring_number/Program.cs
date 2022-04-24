//ПРограмма для возмедения в квадрат
/*
Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine());

int result = number * number;

Console.WriteLine(result);
*/

//Программа, которая принимает два числа и проверяет, является ли первое число квадратом второго

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

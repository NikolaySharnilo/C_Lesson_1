// Task 1: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

void PowNumber(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result *= a;
    }
    Console.WriteLine(result);
}
/* PowNumber(3, 5);
PowNumber(2, 4); */

//Task 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
void SumNumbers(int num)
{
    int result = 0;
    while (num > 0)
    {
        result += num % 10;
        num /= 10;
    }
    Console.WriteLine(result);
}
/* SumNumbers(452);
SumNumbers(82);
SumNumbers(9012); */

//Task 3: Напишите программу, которая задаёт массив из 8 элементов случайными числами и 
//выводит их на экран. Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах)

int[] NewArrayRandom(int count)
{
    int min = 1;
    int max = 100;
    int[] arr = new int[count];
    for (int i = 0; i < count; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

PrintArray(NewArrayRandom(8));

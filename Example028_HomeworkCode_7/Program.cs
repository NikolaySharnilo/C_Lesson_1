int[,] NewArrayRandom(int countR, int countC, int min, int max)
{
    int[,] arr = new int[countR, countC];
    for (int i = 0; i < countR; i++)
    {
        for (int j = 0; j < countC; j++)
        {
            arr[i, j] = new Random().Next(min, max);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintArrayDouble(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Task 0: Задайте двумерный массив. Найдите сумму элементов главной диагонали
int findSumDiagonal()
{
    int[,] arr = NewArrayRandom(3, 3, 1, 10);
    PrintArray(arr);
    int sum = 0;
    int size = arr.GetLength(0);
    if (arr.GetLength(0) > arr.GetLength(1)) size = arr.GetLength(1);

    for (int i = 0; i < size; i++)
        sum += arr[i, i];

    return sum;
}

//Console.WriteLine(findSumDiagonal());

//Task 1: Задайте двумерный массив размеров m*n, заполненный случайными вещественными числами
double[,] NewArrayRandomDoble(int countR, int countC, int min, int max)
{
    double[,] arr = new double[countR, countC];
    for (int i = 0; i < countR; i++)
    {
        for (int j = 0; j < countC; j++)
            arr[i, j] = Math.Round(new Random().NextDouble() + new Random().Next(min, max - 1), 2);
    }
    return arr;



}
//PrintArrayDouble(NewArrayRandomDoble(3, 4, -10, 10));

// Task 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, чо такого элемента нет
string findNumberToArray(int i, int j)
{
    int[,] arr = NewArrayRandom(4, 4, 1, 10);
    PrintArray(arr);

    if (arr.GetLength(0) >= i - 1 && arr.GetLength(1) >= j - 1)
        return $"Число на позиции ({i}, {j}) -> {arr[i - 1, j - 1]} ";
    else
        return $"({i}, {j}) -> такого числа нет в массиве";
}

//Console.WriteLine(findNumberToArray(3,3));

//Task 3: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце
void findMidNumber()
{
    int[,] arr = NewArrayRandom(4, 4, 1, 10);
    PrintArray(arr);

    string txt = "Среднее арифметическое каждого столбца: ";
    double count = arr.GetLength(0);
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double mid = 0;
        for (int i = 0; i < count; i++)
            mid += arr[i, j];

        txt = $"{txt} {mid / count};";
    }
    Console.WriteLine(txt);
}

findMidNumber();

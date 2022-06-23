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

void PrintArray(int [,] arr)
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

void PrintArrayDouble(double [,] arr)
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
            arr[i, j] = Math.Round(new Random().NextDouble() + new Random().Next(min, max-1), 2);
    }
    return arr;



}
PrintArrayDouble(NewArrayRandomDoble(3, 4, -10, 10));
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

int[,] arrayij(int m, int n)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = i + j;
        }
    }
    return arr;
}
//PrintArray(arrayij(3, 4));

void SquareArray()
{
    int[,] arr = NewArrayRandom(4, 6, 2, 10);
    PrintArray(arr);
    for (int i = 1; i < arr.GetLength(0); i += 2)
    {
        for (int j = 1; j < arr.GetLength(1); j += 2)
            arr[i, j] = arr[i, j] * arr[i, j];
    }
    Console.WriteLine();
    PrintArray(arr);
}
//SquareArray();

string findNumverToArray(int num)
{
    int[,] arr = NewArrayRandom(4, 6, 2, 10);
    PrintArray(arr);

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == num)
                return $"Позиция числа {num} -> ({i+1}, {j+1})";
        }
    }
    return $"Числа {num} нет в массиве";

}
//Console.WriteLine(findNumverToArray(2));

// Task 0: Задайте двумерный массив. Найдите сумму элементов главной диагонали
int findSumDiagonal()
{
    int[,] arr = NewArrayRandom(3, 2, 1, 10);
    PrintArray(arr);
    int sum = 0;
    int size = arr.GetLength(0);
    if (arr.GetLength(0) > arr.GetLength(1)) size = arr.GetLength(1);

    for (int i = 0; i < size; i++)
        sum += arr[i, i];
    
    return sum;
}

Console.WriteLine(findSumDiagonal());

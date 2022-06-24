﻿int[,] NewArrayRandom(int countR, int countC, int min, int max)
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
            Console.Write($"{arr[i, j],3} ");
        }
        Console.WriteLine();
    }
}

//Task 0: Составить частотный словарь по массиву
void DictionaryArray()
{

    int[,] arr = NewArrayRandom(3, 3, 0, 10);
    PrintArray(arr);

    var dict = new Dictionary<int, int>();

    foreach (var item in arr)
    {
        if (dict.ContainsKey(item) == false)
            dict.Add(item, 1);
        else
            dict[item]++;
    }

    int min = dict[0];
    int max = dict[0];
    foreach (var item in dict)
    {
        if (min > item.Key) min = item.Key;
        if (max < item.Key) max = item.Key;
    }

    for (int i = min; i < max; i++)
        if (dict.ContainsKey(i) == true) Console.WriteLine($"{i} всречается {dict[i]} раз(а)");
}

//DictionaryArray();

//Task 1: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива

int[,] quikSortRowArrayUp(int[,] arr, int row, int leftIndex, int rightIndex)
{
    int i = leftIndex;
    int j = rightIndex;
    int pivot = arr[row, leftIndex];

    while (i <= j)
    {
        while (arr[row, i] < pivot)
            i++;

        while (arr[row, j] > pivot)
            j--;

        if (i <= j)
        {
            (arr[row, i], arr[row, j]) = (arr[row, j], arr[row, i]);
            i++;
            j--;
        }
    }
    if (leftIndex < j)
        quikSortRowArrayUp(arr, row, leftIndex, j);

    if (rightIndex > i)
        quikSortRowArrayUp(arr, row, i, rightIndex);

    return arr;

}

int[,] quikSortRowArrayDown(int[,] arr, int row, int leftIndex, int rightIndex)
{
    int i = leftIndex;
    int j = rightIndex;
    int pivot = arr[row, leftIndex];

    while (i <= j)
    {
        while (arr[row, i] > pivot)
            i++;

        while (arr[row, j] < pivot)
            j--;

        if (i <= j)
        {
            (arr[row, i], arr[row, j]) = (arr[row, j], arr[row, i]);
            i++;
            j--;
        }
    }
    if (leftIndex < j)
        quikSortRowArrayDown(arr, row, leftIndex, j);

    if (rightIndex > i)
        quikSortRowArrayDown(arr, row, i, rightIndex);

    return arr;

}

int[,] arr = NewArrayRandom(3, 8, 0, 10);
PrintArray(arr);

for (int i = 0; i < arr.GetLength(0); i++)
    arr = quikSortRowArrayDown(arr, i, 0, arr.GetLength(1) - 1);

Console.WriteLine();
PrintArray(arr);


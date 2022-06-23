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
            Console.Write($"{arr[i, j],3} ");
        }
        Console.WriteLine();
    }
}

// Task 0: Заменить первую и последнюю строку массива
void replaceFirstAndEndRowArray()
{
    int[,] arr = NewArrayRandom(3, 3, 1, 10);
    PrintArray(arr);
    int rowCount = arr.GetLength(0) - 1;

    for (int j = 0; j < arr.GetLength(1); j++)
        (arr[0, j], arr[rowCount, j]) = (arr[rowCount, j], arr[0, j]);

    Console.WriteLine();
    PrintArray(arr);
}
//replaceFirstAndEndRowArray();

// Task 0: Заменить строки на столбцы, если это не возможно сообщить об этом
void transporationArray()
{
    int[,] arr = NewArrayRandom(4, 4, 1, 10);
    PrintArray(arr);
    if (arr.GetLength(0) == arr.GetLength(1))
    {
        int x = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = x; j < arr.GetLength(1); j++)
                (arr[i, j], arr[j, x]) = (arr[j, x], arr[i, j]);
            x++;
        }
        Console.WriteLine();
        PrintArray(arr);
    }
    else
        Console.WriteLine("Транспонирование не возможно");
}
//transporationArray();

void eraseRowColumnMinNumber()
{
    int[,] arr = NewArrayRandom(4, 4, 1, 10);
    PrintArray(arr);

    int min = arr[0, 0];
    int indexRowMin = 0;
    int indexColumnMin = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < min)
            {
                min = arr[i, j];
                indexRowMin = i;
                indexColumnMin = j;

            }
        }
    }
    //Console.WriteLine($"{min}, {indexRowMin}, {indexColumnMin}");
    int[,] arr2 = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    int indexRowArr2 = 0;
    int indexColumnArr2 = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (i != indexRowMin)
        {
            indexColumnArr2 = 0;
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (j != indexColumnMin)
                {
                    arr2[indexRowArr2, indexColumnArr2] = arr[i, j];
                    indexColumnArr2++;
                }
            }
            indexRowArr2++;
        }
    }
    Console.WriteLine();
    PrintArray(arr2);
}

eraseRowColumnMinNumber();

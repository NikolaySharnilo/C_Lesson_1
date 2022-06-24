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

DictionaryArray();

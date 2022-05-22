int[] NewArrayRandom(int count, int min, int max)
{
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

void SortMinToMax(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < count; j++)
        {
            if (array[minPosition] > array[j]) minPosition = j;
        }
        if (i != minPosition)
        {
            array[i] = array[i] + array[minPosition];
            array[minPosition] = array[i] - array[minPosition];
            array[i] = array[i] - array[minPosition];
        }

    }
}

void SortMaxToMin(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < count; j++)
        {
            if (array[maxPosition] < array[j]) maxPosition = j;
        }
        if (i != maxPosition)
        {
            array[i] = array[i] + array[maxPosition];
            array[maxPosition] = array[i] - array[maxPosition];
            array[i] = array[i] - array[maxPosition];
        }

    }
}

/* int[] array = new int[12];
array = NewArrayRandom(12, -9, 10);
PrintArray(array);
SumNumber(array); */

void SumNumber(int[] array)
{
    int s_min, s_max;
    s_min = s_max = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            s_min += array[i];
        }
        else
        {
            s_max += array[i];
        }
    }
    Console.WriteLine($"min -> {s_min} max-> {s_max}");

}

void reBadge()
{
    int[] array = NewArrayRandom(12, -9, 10);
    PrintArray(array);
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    PrintArray(array);
}

//reBadge();

void FindNumber(int num)
{
    int[] array = NewArrayRandom(12, -9, 10);
    PrintArray(array);
    string flag = "No";
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            flag = "Yes";
            break;
        }
    }
    Console.WriteLine($"Number {num} - {flag}");
}

//FindNumber(4);

void FindNumberRange(int min, int max)
{
    int[] array = NewArrayRandom(123, 0, 1000);
    PrintArray(array);
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= min & array[i] <= max)
        {
            index++;
        }
    }
    Console.WriteLine(index);
}

//FindNumberRange(10,99);

void MultiplayPair()
{
    int[] array = NewArrayRandom(6, 1, 9);
    PrintArray(array);

    int size = array.Length / 2;
    if ((array.Length % 2) != 0)
    {
        size++;
    }
    Console.WriteLine(size);
    int[] outArr = new int[size];
    int indexOut = 0;
    int index_2 = array.Length - 1;

    for (int index_1 = 0; index_1 < array.Length / 2; index_1++)
    {
        outArr[indexOut] = array[index_1] * array[index_2];
        indexOut++;
        index_2--;
    }
    
    if ((array.Length % 2) != 0)
    {
        outArr[size - 1] = array[size-1];
    }
    PrintArray(outArr);
}
MultiplayPair();


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
// замена местами значений в массиве
void arrSwap()
{
    int[] array = NewArrayRandom(5, 1, 21);
    PrintArray(array);
    int size = array.Length - 1;

    for (int i = 0; i < size / 2 + 1; i++)
    {
        (array[i], array[size - i]) = (array[size - i], array[i]);
    }

    PrintArray(array);
}
//arrSwap();

//программа проверяет может ли существовать треугольник с такими сторонами
void TriangleTrue(int a, int b, int c)
{
    string msg = "False";

    if (a < (b + c) && (b < (a + c)) && (c < (a + b)))
    {
        msg = "True";
    }

    Console.WriteLine(msg);
}
//TriangleTrue(2,2,3);

//программа перобразовывает десятичное число в двоичное
void TenTo2(int number)
{
    string OutNumber = "";
    while (number > 0)
    {
        OutNumber = number % 2 + OutNumber;
        number /= 2;
    }
    Console.WriteLine(OutNumber);
}
//TenTo2(45);

//не используя рекурсию вывести первые N чисел Фибоначчи/ Первые 2 числа 0 и 1
// 5 = 0 1 1 2 3
void FebonachiNumber(int num)
{
    string NumOut = "";
    int a = 0;
    int b = 1;

    for (int i = 0; i < num; i++)
    {
        Console.Write($"{a} ");
        (a, b) = (b, a + b);
    }
    Console.WriteLine();
}

//FebonachiNumber(9);

// программа для создания копии массива с помощью поэлементного копирования
void copyArray()
{
    int[] array = NewArrayRandom(5, 1, 21);
    PrintArray(array);

    int size = array.Length;
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        newArray[i] = array[i];
    }
    PrintArray(newArray);
}
copyArray();
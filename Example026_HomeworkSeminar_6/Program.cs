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

//Task 0: заполнение двумерного массива и его копирование
void copyArray()
{
    int[,] array = NewArrayRandom(5, 3, 1, 21);
    PrintArray(array);

    int sizeR = array.GetLength(0);
    int sizeC = array.GetLength(1);
    int[,] newArray = new int[sizeR, sizeC];

    for (int i = 0; i < sizeR; i++)
    {
        for (int j = 0; j < sizeC; j++)
        {
            newArray[i, j] = array[i, j];
        }

    }
    PrintArray(newArray);
}
//copyArray();

// Task 1: Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввел пользователь
void FindNumber()
{
    Console.WriteLine ("Введите числа через запятую без пробелов");
    string text = Console.ReadLine();
    string[] txt = text.Split(",");
    int size = txt.Length;
    int count = 0;
    for(int i = 0; i < size; i++)
    {
        if (int.Parse(txt[i])>0) count++;
    }
    Console.WriteLine ($"Count positive number = {count}");
}
FindNumber();
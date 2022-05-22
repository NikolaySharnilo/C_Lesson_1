
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

// Task 0: Lection Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
void MultiplayPair()
{
    int[] array = NewArrayRandom(5, 1, 9);
    PrintArray(array);

    int size = array.Length / 2;
    if ((array.Length % 2) != 0)
    {
        size++;
    }

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
        outArr[size - 1] = array[size - 1];
    }
    PrintArray(outArr);
}
//MultiplayPair();

//Task 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

void checkEvenNumber()
{
    int[] arr = NewArrayRandom(10, 100, 1000);
    PrintArray(arr);
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            result++;
        }
    }
    Console.WriteLine(result);
}
//checkEvenNumber();

// Task 2: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

void sumOddNumber()
{
    int[] arr = NewArrayRandom(10, -10, 10);
    PrintArray(arr);
    int result = 0;
    for (int i = 0; i < arr.Length; i += 2)
    {
        result += arr[i];
    }
    Console.WriteLine(result);
}
sumOddNumber(); // Написал так что бы работало как в примере, но были сомнения т.к. по идеи массив начинается с индекса 0, 
//а он, если верить wiki, четный. Наверное тут нужно было бы задать уточняющий вопрос.


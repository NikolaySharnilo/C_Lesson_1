
//Task 1: Есть монотонная последовательность, каждое число встречается ровно то количество раз, какое значение этого числа
//: 1,2,2,3,3,3,4,4,4,4... Выведите ряд последовательности до N-го значения, желательно использовать рекурсию
void RecursionNumOfOneToN(int count, int num = 1, int i = 0)
{

    if (count == 0) return;
    Console.Write($"{num}, ");

    if (i == 0)
    {
        num++;
        i = num;
    }
    RecursionNumOfOneToN(count - 1, num, i - 1);
}

//RecursionNumOfOneToN(12);
//Console.WriteLine();


//Task 2: Повторение матриц. Сформируйте трехмерный массив из неповторяющихся двухзначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

void CreateNewArrayAndPrint(int hight, int row, int column)
{
    int[,,] arr = new int[hight, row, column];
    int startNumber = 10;

    for (int i = 0; i < hight; i++)
    {
        for (int j = 0; j < row; j++)
        {
            for (int z = 0; z < column; z++)
            {
                arr[i, j, z] = startNumber++;
                Console.WriteLine($"({i},{j},{z}) => {arr[i, j, z]}");
            }
        }
    }
}

CreateNewArrayAndPrint(3, 4, 5);
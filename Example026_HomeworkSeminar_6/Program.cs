int[,] NewArrayRandom(int countR, int countC, int min, int max)
{
    int[,] arr = new int[countR, countC];
    for (int i = 0; i < countR; i++)
    {
        for (int j = 0; j < countC; j++)
        {
           arr[i,j] = new Random().Next(min, max); 
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
        for (int j=0; j< sizeC; j++)
        {
            newArray[i,j] = array[i,j];
        }
        
    }
    PrintArray(newArray);
}
copyArray();

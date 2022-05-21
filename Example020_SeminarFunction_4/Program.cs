
int SumToA(int num)
{
    int result = 0;
    for (int i = 1; i <= num; i++)
    {
        result += i;
    }
    return result;
}

/* Console.WriteLine (SumToA(7));
Console.WriteLine (SumToA(4));
Console.WriteLine (SumToA(8)); */

int LenNumber(int num)
{
    return num.ToString().Length;
}

int LenNumber2(int num)
{
    int i = 0;
    while (num > 0)
    {
        num /= 10;
        i++;
    }
    return i;
}

//Console.WriteLine(LenNumber2(456));

int MultiplyToN(int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++)
    {
        result *= i;
    }
    return result;
}

/* Console.WriteLine (MultiplyToN(4));
Console.WriteLine (MultiplyToN(5)); */

void AddToArray()
{
    int[] arr = new int[8];
    for (int i = 0; i < 8; i++)
    {
        arr[i] = new Random().Next(0, 2);
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();

}
AddToArray();

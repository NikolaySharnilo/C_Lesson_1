int NumberRead ()
{
    Console.Write("Введите число: ");
    string a = Console.ReadLine();
    return int.Parse(a);
}

int LastNumber(int number)
{
    number = number % 10;
    return number;
}
int FirstNumber(int number)
{
    number = number / 10;
    return number;
}

//Console.WriteLine (LastNumber(NumberRead()));

int RandomNumber(int number1, int number2)
{
    int a = new Random().Next(number1, number2);
    Console.WriteLine(a);
    return a;
}

void MaxNumber(int firstNumber, int lastNumber)
{
    if (lastNumber < firstNumber)
    {
        Console.WriteLine("Больше первое число: " + firstNumber);
    }
    else
    {
        Console.WriteLine("Больше второе число: " + lastNumber);
    }
}

//int a = RandomNumber(10, 100);
//MaxNumber(FirstNumber(a), LastNumber(a));

void FindDivisible (int number1, int number2)
{
    if (number1 % number2 == 0)
    {
        Console.WriteLine("Числа кратные");
    }
    else
    {
        Console.WriteLine("Числа не кратные, остаток от деления: " + number1 % number2);
    }
}

FindDivisible(NumberRead(), NumberRead());


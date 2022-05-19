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

Console.WriteLine (LastNumber(NumberRead()));
void FindQuarters(int x, int y)
{
    if (x == 0 || y == 0)
    {
        Console.WriteLine($"x -> {x}, y -> {y} ---> нет четверти");
    }
    else if (x > 0 & y > 0)
    {
        Console.WriteLine($"x -> {x}, y -> {y} ---> 1 четверть");
    }


    else if (x < 0 & y > 0)
    {
        Console.WriteLine($"x -> {x}, y -> {y} ---> 2 четверть");
    }

    else if (x < 0 & y < 0)
    {
        Console.WriteLine($"x -> {x}, y -> {y} ---> 3 четверть");
    }

    else if (x > 0 & y < 0)
    {
        Console.WriteLine($"x -> {x}, y -> {y} ---> 4 четверть");
    }
}


/*FindQuarters(2, 2);
FindQuarters(-2, 2);
FindQuarters(-2, -2);
FindQuarters(2, -2);
FindQuarters(0, -2);*/

void FindQuartersSecond(int x)
{
    if (x == 1)
    {
        Console.WriteLine($"Четверть {x} -> x > 0, y > 0");
    }
    else if (x == 2)
    {
        Console.WriteLine($"Четверть {x} -> x < 0, y > 0");
    }
    else if (x == 3)
    {
        Console.WriteLine($"Четверть {x} -> x < 0, y < 0");
    }

    else if (x == 4)
    {
        Console.WriteLine($"Четверть {x} -> x > 0, y < 0");
    }

    else
    {
        Console.WriteLine($"Введите число от 1 до 4");
    }
}

/*FindQuartersSecond(1);
FindQuartersSecond(2);
FindQuartersSecond(3);
FindQuartersSecond(4);
FindQuartersSecond(0);*/

double FindDistance(int x1, int y1, int x2, int y2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 4);
}
//Console.WriteLine(FindDistance(3,6,2,1));

void SqrtNumber(int number)
{
    int index = 0;
    while (index < number)
    {
        Console.WriteLine(Math.Pow(index + 1, 2));
        index++;
    }
}
SqrtNumber(5);
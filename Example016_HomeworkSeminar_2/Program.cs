int NumberRead(string message)
{
    if (message.Length == 0)
    {
        message = "Введите число:";
    }
    Console.Write(message + " ");
    string a = Console.ReadLine();
    return int.Parse(a);
}

void OutputSecondNumber(int number)
{
    Console.WriteLine(number / 10 % 10);
}

//int a = NumberRead("Введите трехзначное число:");
//OutputSecondNumber(a);

int RandomNumber(int number1, int number2)
{
    int a = new Random().Next(number1, number2);
    Console.WriteLine(a);
    return a;
}

void delSecondNumber(int number)
{
    Console.WriteLine($"{ number / 100}{ number % 10}");
}
delSecondNumber(RandomNumber(100,1000));


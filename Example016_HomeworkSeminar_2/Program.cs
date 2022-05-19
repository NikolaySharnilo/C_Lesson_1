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

int a = NumberRead("Введите трехзначное число:");
OutputSecondNumber(a);


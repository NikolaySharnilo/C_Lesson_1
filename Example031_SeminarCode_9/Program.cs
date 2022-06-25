
// 1. Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N при помощи рекурсии

void Requrs(int num)
{
    if (num == 0) return;
    Requrs(num - 1);
    Console.Write($"{num}, ");
}

//Requrs(5);

// 2. Задайте значения от M до N. вывести рекурсией все натуральные числа от M до N
void ValueSet(int M, int N)
{

    if (M > N) return;
    ValueSet(M, N - 1);
    Console.Write($"{N}, ");
}
//ValueSet(3, 8);
// Сумма рекурсии
int sumReq(int a)
{
    if (a == 0) return 0;
    return sumReq(a / 10) + a % 10;
}

//Console.WriteLine(sumReq(1234));
// произведение a до степени b
int sqr(int a, int b)
{
    if (b == 0) return 1 ;
    return sqr(a, b - 1) * a;
}
Console.WriteLine(sqr(2, 3));

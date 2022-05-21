// Task 1: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

void PowNumber(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result *= a;
    }
    Console.WriteLine(result);
}
/* PowNumber(3, 5);
PowNumber(2, 4); */

void SumNumbers(int num)
{
    int result = 0;
    while (num > 0)
    {
        result += num % 10;
        num /= 10;
    }
    Console.WriteLine(result);
}
SumNumbers(452);
SumNumbers(82);
SumNumbers(9012);
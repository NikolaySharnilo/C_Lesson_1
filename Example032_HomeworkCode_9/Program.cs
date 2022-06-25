
// Task 1: Задайте значения M и N. Напишите программу, которая выведет все четные натуральные числа
// в промежутке от M до N с помощью рекурсии.
void ValueSet(int m, int n)
{
    if (m > n) return;
    ValueSet(m, n - 1);
    if (n % 2 == 0) Console.Write($"{n}, ");
}
//ValueSet(4,8);

// Task 2: Задайте значения M и N. Напишите программу, которая 
//найдет сумму натуральных элементов в промежутке от M до N с помощью рекурсии

int sumNumber(int m, int n)
{
    if (m > n) return 0;
    return sumNumber(m, n - 1) + n;
}
Console.WriteLine(sumNumber(4, 8));
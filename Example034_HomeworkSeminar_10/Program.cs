
//Task 1: Есть монотонная последовательность, каждое число встречается ровно то количество раз, какое значение этого числа
//: 1,2,2,3,3,3,4,4,4,4... Выведите ряд последовательности до N-го значения, желательно использовать рекурсию
void RecursionNumOfOneToN(int count, int num = 1, int i = 0)
{

    if (count == 0) return;
    Console.Write($"{num}, ");

    if (i == 0)
    {
        num++;
        i = num;
    }
    RecursionNumOfOneToN(count - 1, num, i - 1);
}

RecursionNumOfOneToN(12);
Console.WriteLine();

// 1. Напишите программу котрая на вход принимает два числа и 
//выдает первые N чиctл для которых каждое следующее равно сумме двух предыдущих
int sumNumber(int a, int b, int N)
{
    if (N == 0) return 0;
    Console.WriteLine(a);
    return sumNumber(b, a + b, N - 1);
}
//sumNumber(6, 10, 4);
// Задача 2: Составить все сочетания из букв а, и, с, в.
char[] arr = {'а', 'и', 'с', 'в'};

void FindWord(char[] arr, char [] dict, int m = 0)
{
    if (m == dict.Length) 
    {
        Console.WriteLine(new String(dict)); 
        return;
    }
    for (int i = 0; i < arr.Length; i++)
    {
        dict[m] = arr[i];
        FindWord(arr, dict, m + 1);
    }
}
FindWord(arr, new char[2]);

// задча 3: Дано натуральное число N. Выведите все его цифры по одной в обратном порядке
// разделяя их пробелами или новыми строками.

void numberOut(int n)
{
    if (n == 0) return;
    Console.WriteLine(n % 10);
    numberOut(n / 10);
}
//numberOut(526);


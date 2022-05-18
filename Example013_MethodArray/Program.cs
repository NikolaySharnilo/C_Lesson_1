int[] array = { 1, 22, 33, 4, 18, 66, 77, 53, 18 };

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
            Console.WriteLine(index);
            break;
    }

    index++;
}
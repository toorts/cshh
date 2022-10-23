int[] array = { 12, 54, 42, 55, 67, 23, 17, 34, 23 };

int n = array.Length;

int find = 23;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++; // index = index + 1
}

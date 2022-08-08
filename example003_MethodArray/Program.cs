Console.Clear();
int[] array = { 9, 8, 7, 2, 5, 4, 3, 2 };
int n = array.Length;
int find = 2;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.Write("Искомый элемент массива имеет index = ");
        Console.WriteLine(index);
        break;
    }
        index++;
}
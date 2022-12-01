void FillArray(int[] colection)
{
    int length = colection.Length;
    int index = 0;
    while (index < length)
    {
        colection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;

    while (position < count)
    {
        System.Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] colection, int find)
{
    int count = colection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if (colection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }

    return position;
}
int[] array = new int[10];

FillArray(array);
PrintArray(array);

System.Console.WriteLine();

int pos = IndexOf(array, 4);
System.Console.WriteLine(pos);
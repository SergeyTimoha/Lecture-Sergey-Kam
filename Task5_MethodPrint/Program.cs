using System;
Console.Clear();
void FillArray(int[] collec)
{
    int length = collec.Length;
    int index = 0;
    while (index < length)
    {
        collec[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
int[] array = new int[5];
FillArray(array);

PrintArray(array);
Console.WriteLine();
int pos = IndexOf(array,2);
Console.WriteLine(pos);
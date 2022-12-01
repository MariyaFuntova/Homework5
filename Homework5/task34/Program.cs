int [] GetRandomArray (int length, int min, int max)
{
    int [] array = new int [length];
    for (int i = 0; i < length; i++)
    {
        array [i] = new Random().Next(min, max+1);
    }
    return array;
}

int GetNumberArray (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

void printArray (int [] array)
{
    Console.Write ("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int [] newArray = GetRandomArray (4, 100, 999);
printArray (newArray);
int count = GetNumberArray(newArray);
Console.WriteLine($"Количество четных чисел в массиве = {count} ");
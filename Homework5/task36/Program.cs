int [] GetRandomArray (int length, int min, int max)
{
    int [] array = new int [length];
    for (int i = 0; i< length; i++)
    {
        array [i] = new Random().Next(min, max+1);
    }
    return array;
}

void printArray (int [] array)
{
    Console.Write("[");
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

int GetSumOddIndex ( int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ( i %2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}
int [] newArray = GetRandomArray (10, -10, 10);
printArray (newArray);
int summa = GetSumOddIndex (newArray);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {summa} ");
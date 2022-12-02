double [] GetRandomArray (int length, int min, int max)
{
    double [] array = new double [length];
    for (int i = 0; i < length; i++)
    {
        array [i] = new Random().Next(min,max + 1);
    }
    return array;
}

void printArray (double [] array)
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

double MaxElementOfArray (double [] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double MinElementOfArray (double [] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double DifferenceElements (double max, double min)
{
    double diff = max - min;
    return diff;
}

double [] newArray = GetRandomArray(5, -10, 50);
printArray(newArray);
double maxElement = MaxElementOfArray(newArray);
double minElement = MinElementOfArray(newArray);
double result = DifferenceElements (maxElement, minElement);
Console.WriteLine($"Максимальный элемент массива = {maxElement}, минимальный = {minElement}");
Console.WriteLine($"Разница между максимальным и минимальным элементами = {result}");
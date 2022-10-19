// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble (int size)
{
    double[] array = new double[size];
    var rnd = new Random ();
    for (int i = 0; i < size; i++)
    {
        double rndNum = rnd.NextDouble() * 100;
        array[i] = Math.Round(rndNum, 1);
    }
    return array;
}

void PrintArray (double[] array)
{
    Console.Write("Массив = [");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length -  1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}
double FindMax (double[] array)
{
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}
double FindMin (double[] array)
{
    double min = 100;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}
double[] arr = CreateArrayRndDouble(5);
PrintArray(arr);
double max = FindMax(arr);
double min = FindMin(arr);
Console.WriteLine($"Разница между макс. и мин. элемантами массива = {max-min}");
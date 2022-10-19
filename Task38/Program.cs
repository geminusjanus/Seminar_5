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

double min = default;
double max = default;
double getSubstraction = default;
if (array[i] > max) max = d[i];
if (array[i] < min) min = d[i];
getSubstraction = max - min;
Console.WriteLine($"Разница между макс. и мин. элементами массива = {getSubstraction}");


double[] arr = CreateArrayRndDouble(5);
PrintArray(arr);

// double[] GetSubtractionMaxMin (double[] array)
// {
//     double getSubstraction = default;
//     double max = default;
//     double min = default;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > max) max = array[i];
//         if (array[i] < min) min = array[i];
//     }
//     getSubstraction = max - min;
//     return getSubstraction;
// }
// Console.WriteLine($"Разница максимального и минимального: {getSubstraction}");

// Random rnd = new Random();
// int[] d = new int[30];
// int max = 0, min = 100;
// for (int i = 0; i < d.Length; i++) d[i] = rnd.Next(100);
// for (int i = 0; i < d.Length; i++)
// {
//     if (d[i] > max) max = d[i];
//     if (d[i] < min) min = d[i];
// }

// for (int i = 0; i < d.Length; i++) Console.Write($"{d[i]} ");
// Console.WriteLine();
// Console.WriteLine($"max: {max}");
// Console.WriteLine($"min: {min}");
// Console.WriteLine($"Разница максимального и минимального: {max - min}");

// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArrayRndInt(int size)
{
    int[] array = new int[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(100, 999);

    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("Массив = [");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}
int[] arr = CreateArrayRndInt(4);
PrintArray(arr);

int count = default;
for (int i = 0; i < arr.Length; i++)
        if (arr[i] % 2 == 0)
            count++;
Console.WriteLine($"Количество четных чисел в массиве равно  {count}");
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


Random rnd = new Random();
int[] d = new int[30];
int max = 0, min = 100;
for (int i = 0; i < d.Length; i++) d[i] = rnd.Next(100);
for (int i = 0; i < d.Length; i++)
{
    if (d[i] > max) max = d[i];
    if (d[i] < min) min = d[i];
}

for (int i = 0; i < d.Length; i++) Console.Write($"{d[i]} ");
Console.WriteLine();
Console.WriteLine($"max: {max}");
Console.WriteLine($"min: {min}");
Console.WriteLine($"Разница максимального и минимального: {max - min}");

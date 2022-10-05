// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
int[] arr = new int[5];
Random rnd = new Random();

int n = 5;
int j = 0;
for (int i = 0; i < n; i++)
{
    arr[i] = rnd.Next(0, 99);
    Console.Write("{0} ", arr[i]);
}
Console.WriteLine();
var min = arr[0];
var max = arr[0]; 
var minIndex = 0;
var maxIndex = 0;
 
for (j = 0; j < n; j++)
{
    if (arr[j] < min)
    {
        min = arr[j];
        minIndex = j;
    }
    else if (arr[j] > max)
    {
        max = arr[j];
        maxIndex = j;
    }
}
Console.WriteLine($"Разница между мин и макс = {max - min}");
Console.WriteLine();
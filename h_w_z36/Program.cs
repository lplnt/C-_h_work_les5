// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
int[] arr = new int[4];
Random rnd = new Random();
Console.Write("Случайный массив:");
for (int i = 0; i < 4; i++)
{
    arr[i] = rnd.Next(-99, 100);
    Console.Write("{0} ", arr[i]);
}
Console.WriteLine();
Console.WriteLine($"Сумма нечетных позиций = {arr[1] + arr[3]}");
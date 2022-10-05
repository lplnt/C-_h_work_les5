// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
int n = 4;
int[] arr = new int[n];
//int k = 0; 
int sum = 0;
Random rnd = new Random();
 
Console.WriteLine("Случайный массив");
for (int i = 0; i < n; i++)
{
    arr[i] = rnd.Next(99, 1000);
    Console.Write("{0} ", arr[i]);
    
    if(arr[i]%2== 0)
    {   
        sum++;
    }
}
Console.WriteLine(" Кол-во четных чисел = " + sum);
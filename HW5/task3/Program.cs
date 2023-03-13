// See https://aka.ms/new-console-template for more information
/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

int[] func(int len)
{
    int[] arr = new int[len];

    for(int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(0,100);
    }
    return arr;
}

int o = int.Parse(Console.ReadLine()!);
int[] mass = func(o);
int min = mass[0];
int max = mass[0];

for(int i = 0; i < mass.Length; i++)
{
    if(max < mass[i]) max = mass[i];
    if(min > mass[i]) min = mass[i];
    Console.Write($"{mass[i]} ");
}
Console.WriteLine();
Console.Write($"[{min}...{max}] -> {min+max}");
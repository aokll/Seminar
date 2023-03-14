// See https://aka.ms/new-console-template for more information
/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/




int[] func(int len)
{
    int[] arr = new int[len];

    for(int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(100,999);
    }
    return arr;
}


int k = 0;
int o = int.Parse(Console.ReadLine()!);
int[] mass = func(o);


for(int i = 0; i < mass.Length; i++)
{
    if(mass[i]%2 == 0){
        k++;
    }
    Console.Write(mass[i] + " ");
}


Console.WriteLine();
Console.Write($"количество четных чисел = {k}");


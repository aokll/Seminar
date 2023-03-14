// See https://aka.ms/new-console-template for more information
/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/

int[] func(int len)
{
    int[] arr = new int[len];

    for(int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(0,200);
    }
    return arr;
}

int res = 0;
int o = int.Parse(Console.ReadLine()!);
int[] mass = func(o);


for(int i = 0; i < mass.Length; i++)
{
    if(i%2 != 0){
       res += mass[i];
    }
    Console.Write($"{mass[i]}[{i}] ");
}
Console.WriteLine();
Console.Write($"Сумма всех чисел на нечетных позициях = {res}");
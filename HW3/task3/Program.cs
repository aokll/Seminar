// See https://aka.ms/new-console-template for more information
/*Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

void func(int q)
{
    for(int i = 1; i <= q; i++){
        int res = i*i*i;
        Console.Write(res + " ");
    }
    
}
int x = int.Parse(Console.ReadLine()!);
func(x);
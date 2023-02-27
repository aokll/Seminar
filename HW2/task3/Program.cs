// See https://aka.ms/new-console-template for more information

/*Задача 15: Напишите программу, которая принимает 
на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

void week(int i)
{
    if(i == 1 || i == 2 || i == 3 || i == 4 || i == 5)Console.WriteLine("no");
    if(i == 6 || i == 7)Console.WriteLine("yes");
}
week(1);
week(6);

// See https://aka.ms/new-console-template for more information
/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет*/

String a1 = Console.ReadLine()!;
int b1 = int.Parse(a1);
if(b1%2==0)Console.Write(b1 + " четное");
else Console.Write(b1 + " нечетное");
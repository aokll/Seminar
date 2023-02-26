// See https://aka.ms/new-console-template for more information

/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

String a1 = Console.ReadLine()!;
String a2 = Console.ReadLine()!;
int b1 = int.Parse(a1);
int b2 = int.Parse(a2);
if(b1>b2)Console.Write(b1 + ">" + b2);
else if(b1<b2)Console.Write(b1 + "<" + b2);
else Console.Write(b1 + "=" + b2);


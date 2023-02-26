// See https://aka.ms/new-console-template for more information
/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

String a1 = Console.ReadLine()!;
String a2 = Console.ReadLine()!;
String a3 = Console.ReadLine()!;
int b1 = int.Parse(a1);
int b2 = int.Parse(a2);
int b3 = int.Parse(a3);

if(b1>b2 && b1>b3)Console.Write(b1 + "max");
if(b2>b1 && b2>b3)Console.Write(b2 + "max");
if(b3>b1 && b3>b2)Console.Write(b3 + "max");

    

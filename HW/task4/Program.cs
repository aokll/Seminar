// See https://aka.ms/new-console-template for more information

/*Задача 8: Напишите программу, которая на вход принимает число (N),
 а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/

String a1 = Console.ReadLine()!;
int b1 = int.Parse(a1);
int i = 1;

while(i <= b1){
    if(i%2==0)Console.Write(i + " ");
    i++;
}

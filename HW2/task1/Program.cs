// See https://aka.ms/new-console-template for more information

/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/
int o = new Random().Next(100,1000);
String s = o.ToString();

char[] arr = s.ToCharArray();

for(int i = 0; i<arr.Length; i++){
    if(i == 1) Console.Write(o + " -> " + arr[i] + " ");
}

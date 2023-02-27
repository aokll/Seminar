// See https://aka.ms/new-console-template for more information

/*Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

int o = new Random().Next(0,200);
String s = o.ToString();

char[] arr = s.ToCharArray();

if(arr.Length >= 3)
{
for(int i = 0; i<arr.Length; i++){
    if(i == 2) Console.Write(o + " -> " + arr[i] + " ");
}
}else Console.Write(o + " -> " + "Такой цифры нет");
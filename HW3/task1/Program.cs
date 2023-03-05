// See https://aka.ms/new-console-template for more information

/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да*/

//int o = new Random().Next(9999,99999);
int o = 23432;
String s = o.ToString();

char[] arr = s.ToCharArray();
int p = 0;

if(arr[0] == arr[4]){
    p++;
    if(arr[1] == arr[3]){
        p++;
    }
}

if(p == 2){
    Console.WriteLine($"{o} - палендром");
}else Console.WriteLine($"{o} - непалендром");

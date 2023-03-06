// See https://aka.ms/new-console-template for more information

/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/

int func(int x)
{
    int res = 0;;
String s = x.ToString();
char[] arr = s.ToCharArray();

for(int i = 0; i < arr.Length; i++){
    int k = arr[i] - '0';
    res += k;
}
return res;
}

int a = int.Parse(Console.ReadLine()!);
Console.WriteLine(func(a));
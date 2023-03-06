// See https://aka.ms/new-console-template for more information

/*Задача 25: Напишите цикл, который принимает на вход два числа 
(A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/

int func (int a,int b)
{
    int res = 0;
    for(int i = 0; i < b-1; i++){
        if(i == 0){
            res = a*1;
        }
        res*=a;
    }
    return res;
}
int x = int.Parse(Console.ReadLine()!);
int y = int.Parse(Console.ReadLine()!);
Console.WriteLine(func(x,y));
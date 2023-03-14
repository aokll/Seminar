// See https://aka.ms/new-console-template for more information

//Последняя задача из урока

/*[1,2,3,4,5] -> 5,8,3
[1,2,3,4] -> 4,6*/

int[] func(int len)//Создание массива с заданным колличеством элементов
{
    int[] arr = new int[len];

    for(int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(0,100);
    }
    return arr;
}

int o = int.Parse(Console.ReadLine()!);
int[] mass = func(o);

for(int i = 0; i < mass.Length; i++)//Вывод массива для наглядности
{
    Console.Write($"{mass[i]} ");
}

Console.WriteLine();

if(mass.Length%2 == 0){//Вывод суммы чисел массива с четным количеством элементов
    for(int i = 0; i < mass.Length/2; i++)
    {
        for(int j = mass.Length-1; j > (mass.Length/2)-1; j--)
        {
                    if(j == (mass.Length-1)-i)
                    {
                        Console.Write($"{mass[i]+mass[j]} ");
                    }
        }
            
    }
}

else{//Вывод суммы чисел массива с нечетным количеством элементов
    for(int i = 0; i < mass.Length/2; i++)
    {
        for(int j = mass.Length-1; j > (mass.Length/2)-1; j--)
        {
                    if(j == (mass.Length-1)-i)
                    {
                        Console.Write($"{mass[i]+mass[j]} ");
                    }
        }
            
    }
    Console.Write($"{mass[mass.Length/2]}");

}
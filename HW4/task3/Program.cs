// See https://aka.ms/new-console-template for more information

/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/

void func(int x)
{
    

    String s = x.ToString();
    char[] arr1 = s.ToCharArray();

    int[] arr = new int[arr1.Length];

    for(int i = 0; i < arr1.Length; i++)
    {
        if(i == 0){Console.Write("[");}
        
        int a = arr1[i] - '0';
        arr[i] = a;
        
        if(i == arr1.Length - 1)
        {
            Console.Write(arr[i] + "]");
        }else Console.Write(arr[i] + ", ");
    }
}
int r = int.Parse(Console.ReadLine()!);
func(r);
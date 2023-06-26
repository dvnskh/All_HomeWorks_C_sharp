// int Summ (int num)
// {
//     if (num==0) return 0;
//     return num%10+Summ(num/10);
    
// }
// System.Console.WriteLine("Введите целое число");
// int num=Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"{Summ(num)}");

// int Build(int n, int m)
// {
//     if (m==0) return 1;
//     return n*Build(n,m-1);
// }
//  System.Console.WriteLine("Введите число ");
//  int n=Convert.ToInt32(Console.ReadLine());
//  System.Console.WriteLine("В какую степень возвести ? ");
//  int m=Convert.ToInt32(Console.ReadLine());
//  System.Console.WriteLine(Build(n,m));


// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"



System.Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Build(a));
string Build (int a)
{
    if (a==0) return "1";
    return a + "," + Build(a - 1);
}
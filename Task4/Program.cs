// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int x1 = 2;
int x2 = 3;
int x3 = 7;
int max=x3;
if (x1>x2) x1=max;
if (x2>x3) x2=max;
if (x3>x1) x3=max;
System.Console.WriteLine(max);
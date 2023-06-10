﻿// //Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// // 456 -> 5
// // 782 -> 8
// // 918 -> 1
System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int a=num/10;
int a3=a%10;
System.Console.WriteLine($"{a3}");
﻿// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

System.Console.WriteLine("Vvedite pervoe chislo");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Vvedite vtoroe chislo");
int b = Convert.ToInt32(Console.ReadLine());
if (b * b == a)
{
   Console.WriteLine("Pervoe chislo yavyaetsa kvadratom vtorogo");
}
else
{
    Console.WriteLine("нет");
}

﻿// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8


System.Console.WriteLine("Введите трехзначное число : ");
int N = Convert.ToInt32(Console.ReadLine()); //// для всех чисел включая отрицательные добавляем Math.Abs(Convert.ToInt32(Console.ReadLine()))
if (N > 99 && N < 1000)
{
    System.Console.WriteLine("Последняя цифра этого числа -  " + N % 10);
}
else
{
    System.Console.WriteLine("Введено не трехзначное число");
}
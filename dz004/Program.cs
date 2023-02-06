// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// 1 решение
// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());

// int a = 2;

// if(N > 1)
// {
//     while(a <= number)
//     {
//         Console.Write(a + " ");
//         a = a + 2;
//     }
// }


// 2 решение
System.Console.WriteLine("Введите число N");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i <= number; i = i + 2)
{
    System.Console.Write(i + " ");
}
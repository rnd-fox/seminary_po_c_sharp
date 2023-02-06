// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


System.Console.WriteLine("Vvedite pervoe chislo");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Vvedite vtoroe chislo");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Vvedite tret'e chislo");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (a > b)
{
    if (a > c)
    {
        Console.Write("max = ");
        System.Console.Write(max = a);
    }
    else
    {
        Console.Write("max = ");
        System.Console.Write(max = c);
    }
}
else if (b > c)
{
    Console.Write("max = ");
    System.Console.Write(max = b);
}
else
{
    Console.Write("max = ");
    System.Console.Write(max = c);
}
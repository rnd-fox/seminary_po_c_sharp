// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница
Console.WriteLine("Введите номер дня недели");
string den = Console.ReadLine();

if(den == "1")
{
    Console.WriteLine("Понедельник");
}
if(den == "2")
{
    Console.WriteLine("Вторник");
}
if(den == "3")
{
    Console.WriteLine("Среда");
}
if(den == "4")
{
    Console.WriteLine("Четверг");
}
if(den == "5")
{
    Console.WriteLine("Пятница");
}
if(den == "6")
{
    Console.WriteLine("Суббота");
}
if(den == "7")
{
    Console.WriteLine("Воскресенье");
}
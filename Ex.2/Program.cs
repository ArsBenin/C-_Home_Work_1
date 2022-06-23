/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("введите первое число");
string first = Console.ReadLine();
int firstnumber = int.Parse(first);

Console.WriteLine("введите второе число");
string second = Console.ReadLine();
int secondnumber = int.Parse(second);

if (firstnumber == secondnumber)
{
    Console.WriteLine("числа равны");
}
else if (firstnumber > secondnumber)
{
    Console.WriteLine($"max {firstnumber}");
}
else if (firstnumber < secondnumber)
{
    Console.WriteLine($"max {secondnumber}");
}
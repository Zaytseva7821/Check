﻿//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
Console.WriteLine("Введите число 1");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int b = Convert.ToInt32(Console.ReadLine());
if (a < b)
{
    System.Console.Write("max = ");
    System.Console.WriteLine(b);
    System.Console.Write("min = ");
    System.Console.WriteLine(a);
}
else
{
    System.Console.Write("max = ");
    System.Console.WriteLine(a);
    System.Console.Write("min = ");
    System.Console.WriteLine(b);
}
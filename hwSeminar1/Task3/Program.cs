﻿// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == -1 ||a % 2 == 1 )
{
    Console.WriteLine (a+"Нечетное");
}
else
{
    Console.WriteLine(a+ "Четное");
}

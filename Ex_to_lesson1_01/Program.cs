﻿// See https://aka.ms/new-console-template for more information
//https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/xmldoc/
/*Задача 1: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
int a = 22, b = 33, c = 9;
Console.WriteLine(a > b & a > c ? $"Max a = {a}" : c > b & c > a ? $"Max c = {c}" : $"Max b = {b}" );

/*Задача 2: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/
int d = 7;
Console.WriteLine(d % 2 == 0 ? $"Число d = {d} чётное" : $"Число d = {d} нечётное");

/*Задача 3: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Чётные числа от 1 до N = {N} :");
for (int i = 2; i <= N; i+=2)
{
    Console.WriteLine(i);
}




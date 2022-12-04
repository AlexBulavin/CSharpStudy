// Программа проверяет пятизначное число на палиндромом
/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
СТРОКИ ИСПОЛЬЗОВАТЬ НЕЛЬЗЯ
*/
////git push https://ghp_bA2****************3vtX0M@github.com/AlexBulavin/CSharpStudy.git
int number = 0;
while (number < 10000 | number > 99999) 
{
Console.Write("Введите пятизначное число:");
number = Convert.ToInt32(Console.ReadLine());
}
int fiftForth = number/1000;
// Console.WriteLine($"fiftForth = {fiftForth}");
int firstSecond = (number%10)*10 + (number%100)/10;
// Console.WriteLine($"firstSecond = {firstSecond}");
    Console.WriteLine(fiftForth == firstSecond ? "палиндром" : "не палиндром");


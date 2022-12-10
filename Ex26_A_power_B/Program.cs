// Возведите число А в натуральную степень B используя цикл
//git push https://ghp_bA2****************3vtX0M@github.com/AlexBulavin/CSharpStudy.git
using static System.Console;

Console.Write("\nВведите натуральное число N: ");
double N = Convert.ToDouble(Console.ReadLine());
Console.Write("\nВведите степень M возведения числа N: ");
int M = Convert.ToInt32(Console.ReadLine());
double power = N;
Console.WriteLine("");

for (int i = 1; i < M; i++)
{
    power *= N;
}
WriteLine($"{N} в степени {M} = {power.ToString(" ### ### ### ### ### ### ### ### ### ### ### ### ###")}\n");

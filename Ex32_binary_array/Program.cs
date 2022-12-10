/*Задача 29: Напишите программу, которая задаёт массив из N элементов (из диапазона [0-14] ) и выводит на экран десятичное представление числа, записанного в СС по основанию 15
N: 3 [9, 4, 12] => 2097
Для проверки можно использовать https://numsys.ru/convert/2097/10/15
*/
//git push https://ghp_bA2****************3vtX0M@github.com/AlexBulavin/CSharpStudy.git
using static MyLibrary123;
using static System.Console;

Write($"Введите размерность массива: ");
int M = Convert.ToInt32(Console.ReadLine());
WriteLine();
Write($"Введите основание системы счисления: ");
int N = Convert.ToInt32(Console.ReadLine());
WriteLine();

int[] arr = new int[M];
long res = 0;
long temp = 0;

for (int i = 0; i < M; i++)
{
    arr[i] = Random.Shared.Next(0, N);
    temp = (long)(arr[i] * Math.Pow(N, M - i));
    Write($"{arr[i]}*{N}^{M-i}");
    Write(i < M-1 ? " + " : "\n");
    res += temp;
}
WriteLine();
WriteLine($"{String.Join("", arr)}\u2081\u2085 = {res}\u2081\u2080\n");//в {CountSystem(N)} 
WriteLine();
//Надстрочный регистр \u00B2
//Подстрочные регистры: '\u208*' где * - любой символ,

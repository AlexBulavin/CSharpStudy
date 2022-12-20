/*
66. Показать натуральные числа от 1 до N, N задано
67. Показать натуральные числа от N до 1, N задано
*/

using static MyLibrary;
using static System.Console;
public class Recursion
{
    public static void Natural1NPrint()
    {
        Console.Clear();//Очищаем консоль
        bool DEBUG = false;//true;// Задаём режим работы - дебаг или прод 
        int n = Input("Введите натуральное число N: ");
        string output = String.Empty;

        //Выводим через рекурсию.
        ChangeForegroundColor(4);
        WriteLine($"{NaturalRayOpposit(1,n)}");
        WriteLine($"{NaturalRay(n)}");
        Console.ResetColor();
    }

    public static string NaturalRay(int N)
    {
        string output = String.Empty;
        if (N > 0) output += $"{N} {NaturalRay(N - 1)}";

        return output;
    }

    public static string NaturalRayOpposit(int count, int N)
    {
        string output = String.Empty;
        if (count <= N) output += $"{count} {NaturalRayOpposit(count + 1, N)}";

        return output;
    }
}
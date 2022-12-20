/*Показать натуральные числа от 1 до N, N задано */
using static MyLibrary;
using static System.Console;
public class RecursionNM
{
    public static void NaturalNMPrint()
    {
        Console.Clear();//Очищаем консоль
        bool DEBUG = false;//true;// Задаём режим работы - дебаг или прод 
        int n = Input("Введите натуральное число N: ");
        int m = Input("Введите натуральное число M: ");
        string output = String.Empty;

        //Выводим через рекурсию.
        ChangeForegroundColor(4);
        WriteLine($"{Recursion.NaturalRayOpposit(n, m)}");
        Console.ResetColor();
    }
}
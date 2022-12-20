/* Найти сумму элементов от M до N, N и M заданы */
using static MyLibrary;
using static System.Console;
public class RecursionSum
{
    public static void NaturalNMPrint()
    {
        Console.Clear();//Очищаем консоль
        bool DEBUG = false;//true;// Задаём режим работы - дебаг или прод 
        // Вводим числа N и M
        int n = Input("Введите натуральное число N: ");
        int m = n + 1;
        while (m > n)
        {
            m = Input($"Введите натуральное число M, больше {n}: ");
        }

        //Выводим через рекурсию.
        ChangeForegroundColor(4);
        WriteLine($"Сумма чисел от {n} до {m} равна {NMSum(n, m, DEBUG)}");
        Console.ResetColor();
    }
    public static int NMSum(int n, int m, bool DEBUG)
    {
        int sum = n;
        if (DEBUG) WriteLine($"Iterator n = {n}, sum = {sum}");
        if (n < m) sum += NMSum(n + 1, m, DEBUG);
        if (DEBUG) WriteLine($"After recursion sum = {sum}");
        return sum;
    }
}
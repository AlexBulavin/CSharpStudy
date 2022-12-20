/* 70. Найти сумму цифр числа */
using static MyLibrary;
using static System.Console;
public class RecursionSum1N
{
    public static void Sum1ToNPrint()
    {
        Console.Clear();//Очищаем консоль
        bool DEBUG = false;//true;// Задаём режим работы - дебаг или прод 
        // Вводим числа N и M
        int n = Input("Введите натуральное число N: ");

        //Выводим через рекурсию.
        ChangeForegroundColor(4);
        WriteLine($"Сумма цифр числа {n} равна {NDigitsSum(n, DEBUG)}");
        Console.ResetColor();
    }
    public static int NDigitsSum(int n, bool DEBUG)
    {
        int sum = 0;
        int digits = MyLibrary.DigitsInNumber(n);
        int temp = (int)(n/(Math.Pow(10, digits - 1)));
            if (DEBUG) WriteLine($"Iterator n = {n}, sum = {sum}, temp = {temp} digits = {digits}");
        if (n > 9) 
        {
            sum += temp + NDigitsSum(n % (int)(Math.Pow(10, digits - 1)), DEBUG);            
        }
        else sum += n;
            if (DEBUG) WriteLine($"After recursion sum = {sum}");
        return sum;
    }
}
//72. Написать программу возведения числа А в целую стень B

using static MyLibrary;
using static System.Console;
public class APowerB
{
    public static uint Depth = 0;
    public static void APowerBMain()
    {
        Console.Clear();//Очищаем консоль
        bool DEBUG = true;//false;// Задаём режим работы - дебаг или прод 
        //Фиксируем время
        DateTime startTime = DateTime.Now;

        // Вводим числа N и M
        float a;
        int b;
        a = InputFloat("Введите число A: ", DEBUG);
        b = Input("Введите целочисленную степень числа А{}: ");
        WriteLine();
        ChangeForegroundColor(4);

        //Выводим A^B через рекурсию.

        WriteLine($"\nФункция {a}{CharSelector(b, 1)} = {APowerBRecursion(a, b, b > 0 ? 1 : -1, startTime, DEBUG)}\n");
        ChangeForegroundColor(6);
        WriteLine($"Начало вычислений {startTime.ToString()}");
        WriteLine($"Окончание вычислений {DateTime.Now.ToString()}");
        WriteLine($"Продолжительность вычислений {((DateTime.Now - startTime)).TotalMilliseconds} миллисекунд\n");
        ResetColor();
    }
    public static float APowerBRecursion(float number, int power, int count, DateTime requestTime, bool DEBUG)
    {
        DateTime APowerBRecursionTime = DateTime.Now;
        Depth++;
        if (DEBUG)
        {
            ChangeForegroundColor(5);
            WriteLine($"number = {number}\tpower = {power}\tDepth = {Depth}\t{APowerBRecursionTime.Hour.ToString()}:{APowerBRecursionTime.Minute.ToString()}:{APowerBRecursionTime.Second.ToString()}\t{APowerBRecursionTime - requestTime}");
        }
        float output = number;

        if (power == 0) return 1;
        if (power < 0)
        {
            output = 1/number;
            if (count > power) output *= APowerBRecursion(number, power, count - 1, requestTime, DEBUG);
        }
        else
        {
            if (count < power) output *= APowerBRecursion(number, power, count + 1, requestTime, DEBUG);
        }
        ChangeForegroundColor(4);
        return output;
    }
}
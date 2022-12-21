//72. Написать программу возведения числа А в целую степень B

using static MyLibrary;
using static System.Console;
public class APowerB
{
    public static uint Depth = 0;
    public static void APowerBMain()
    {
        Console.Clear();//Очищаем консоль
        bool DEBUG = false;//true;// Задаём режим работы - дебаг или прод 
        //Фиксируем время
        DateTime startTime = DateTime.Now;

        // Вводим числа N и M
        float a;
        int b;
        a = InputFloat("Введите число A: ", DEBUG);
        b = Input("Введите целочисленную степень числа А: ");
        ChangeForegroundColor(4);
        //Выводим A^B через рекурсию.
        WriteLine($"\nФункция {a}{FillOneDimArrayBySubscriptSuperscript(b, 1, DEBUG)} = {APowerBRecursion(a, b, b > 0 ? 1 : -1, startTime, DEBUG)}\n");
        ResetColor();
        ProgramMonitoring(startTime, DEBUG);
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
            output = 1 / number;
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

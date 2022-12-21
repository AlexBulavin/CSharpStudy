/* 71. Написать программу вычисления функции Аккермана */
using static MyLibrary;
using static System.Console;
public class Ackerman
{
    public static uint Depth = 0;
    public static void FuncMain()
    {
        Console.Clear();//Очищаем консоль
        bool DEBUG = true;//false;// Задаём режим работы - дебаг или прод 
        //Фиксируем время
        DateTime startTime = DateTime.Now;
        
        // Вводим числа N и M
        uint n = 13;
        uint m = 11;
        while (n > 12) n = InputUint("Введите натуральное число N 0..12: ", DEBUG);
        while (m > 10) m = InputUint("Введите натуральное число M 0..10: ", DEBUG);
        
        if (n < 0 | m < 0) throw new ArgumentOutOfRangeException();
        /*
        Формулу смотреть здесь: ackerman.svg
        */
        ChangeForegroundColor(4);
        //Выводим через рекурсию.

        WriteLine($"Функция Акермана({n}, {m}) = {FuncAckerman(n, m, startTime, DEBUG)}, Depth = {Depth}");
        Console.ResetColor();
        WriteLine($"Начало вычислений {startTime.ToString()}");
        WriteLine($"Окончание вычислений {DateTime.Now.ToString()}");
        WriteLine($"Продолжительность вычислений {((DateTime.Now - startTime)).TotalMilliseconds}миллисекунд");
    }
    public static uint FuncAckerman(uint number, uint argument, DateTime requestTime, bool DEBUG)
    {
        DateTime funcAkermanTime = DateTime.Now;
        Depth++;
        if (DEBUG) WriteLine($"number = {number}\targument = {argument}\tDepth = {Depth}\t{funcAkermanTime.Hour.ToString()}:{funcAkermanTime.Minute.ToString()}:{funcAkermanTime.Second.ToString()}\t{funcAkermanTime - requestTime}\r");
        
        if (number == 0) return argument + 1;
        if (argument == 0) return FuncAckerman(number - 1, 1, funcAkermanTime, DEBUG);

        return FuncAckerman(number - 1, (FuncAckerman(number, argument - 1, funcAkermanTime, DEBUG)), funcAkermanTime, DEBUG);

        //return FuncAckerman(number, argument, DEBUG);//result;
    }
}
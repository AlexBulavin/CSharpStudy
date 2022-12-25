using static MyLibrary;
using static System.Console;
using static TetrisSourceLibrary;
public class TestConsole
{

    public static void TstMain()
    {
        //Фиксируем время начала работы программы
        DateTime startTime = DateTime.Now;
        Console.Clear();//Очищаем консоль
        bool DEBUG = true;//false;// Задаём режим работы - дебаг или прод 
        int count = 1;
        //SETTINGS
        int x = Input($"Input x");
        MainAlgorithm(x, ref count);
        Write($"Количество путей {count} \n");

    }

    static void MainAlgorithm(int x, ref int count)
    {
        if (x + 1 <= 4)
            if (x * 2 <= 4)
            {
                count++;
                MainAlgorithm(x + 1, ref count);
                MainAlgorithm(x * 2, ref count);
            }
    }
}


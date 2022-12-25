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
        int x = Input($"Введите начальное значение x: ");
        int max = Input($"Ввести максимальное значение max: ");
        MainAlgorithm(x, max, ref count);
        Write($"Количество путей {count}\n");

    }

    static void MainAlgorithm(int x, int max, ref int count)
    {
        if (x + 1 <= max & x * 2 <= max)
            {
                count++;
                MainAlgorithm(x + 1, max, ref count);
                MainAlgorithm(x * 2, max, ref count);
            }
    }
}


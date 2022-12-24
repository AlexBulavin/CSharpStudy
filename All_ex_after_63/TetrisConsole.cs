
using static MyLibrary;
using static System.Console;
using static TetrisSourceLibrary;
public class TetrisConsole
{

    public static bool TetrisMain()
    {
        //Фиксируем время начала работы программы
        DateTime startTime = DateTime.Now;
        Console.Clear();//Очищаем консоль
        bool DEBUG = true;//false;// Задаём режим работы - дебаг или прод 

        //SETTINGS
        int xPosition = Random.Shared.Next(10, Console.WindowWidth - 10);
        int yPosition = 2;
        char filler = '█';
        bool motionFreezer = true;//Значение false останавливает движение
        int figuresMax = 3;
        int currentFigure = Random.Shared.Next(0, figuresMax);
        int colorNumber = 4;

        CursorVisible = false;

        // Логика отрисовки всего
        new Thread(() =>
        {
            while (motionFreezer)
            {
                //Поставить рандомайзер сюда
                FigureExtractor(currentFigure, xPosition, yPosition, filler, colorNumber);
                Thread.Sleep(50);
                yPosition++;
                if (yPosition > Console.WindowHeight - 10)
                {
                    yPosition = 1;
                    xPosition = Random.Shared.Next(10, Console.WindowWidth - 10);
                    currentFigure = Random.Shared.Next(0, figuresMax);
                }
            }
        }).Start();

        // Логика проверки нажатия кнопок
        while (true)
        {
            var key = Console.ReadKey(true).Key;

            if (key == ConsoleKey.LeftArrow)
            {
                xPosition--;
                FigureExtractor(currentFigure, xPosition, yPosition, filler, colorNumber);
            }
            if (key == ConsoleKey.RightArrow)
            {
                xPosition++;
                FigureExtractor(currentFigure, xPosition, yPosition, filler, colorNumber);

            }

            if (key == ConsoleKey.Spacebar)
            {
                motionFreezer = !motionFreezer;
            }

        }
    }
}
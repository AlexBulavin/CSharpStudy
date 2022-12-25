
using static MyLibrary;
using static System.Console;
using static TetrisSourceLibrary;
public class TetrisConsole
{

    public static void TetrisMain()
    {
        //Фиксируем время начала работы программы
        DateTime startTime = DateTime.Now;
        Console.Clear();//Очищаем консоль
        bool DEBUG = true;//false;// Задаём режим работы - дебаг или прод 

        //SETTINGS
        int xPosition = Random.Shared.Next(10, Console.WindowWidth - 10);
        int yPosition = 2;
        char filler = '█';
        int figureOrientation = 1;
        bool motionFreezer = false; //true останавливает движение
        int figuresMax = 3;//Количество фигур
        int currentFigure = Random.Shared.Next(0, figuresMax);//Рандомайзер по фигурам

        CursorVisible = false;

        // Логика отрисовки всего
        new Thread(() =>
        {
            while (true)
            {
                //Поставить рандомайзер фигур сюда
                Clear();
                if (DEBUG)
                {
                    SetCursorPosition(0, Console.WindowHeight - 1);
                    Write(figureOrientation);
                }
                FigureExtractor(currentFigure, xPosition, yPosition, filler, figureOrientation, ref DEBUG);

                Thread.Sleep(100);
                yPosition = !motionFreezer ? yPosition + 1 : yPosition;
                if (yPosition > Console.WindowHeight - 10)
                {
                    yPosition = 1;
                    xPosition = Random.Shared.Next(10, Console.WindowWidth - 10);
                    currentFigure = Random.Shared.Next(0, figuresMax);
                }
            }
        }).Start();

        KeyListener(xPosition, yPosition, ref currentFigure, filler, ref figureOrientation, ref motionFreezer, ref DEBUG);
    }
    public static void KeyListener(int xPosition, int yPosition, ref int currentFigure, char filler, ref int figureOrientation, ref bool motionFreezer, ref bool DEBUG)
    {
        // Логика обработки нажатия кнопок
        while (true)
        {
            var key = Console.ReadKey(true).Key;

            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    xPosition--;
                    FigureExtractor(currentFigure, xPosition, yPosition, filler, figureOrientation, ref DEBUG);
                    break;

                case ConsoleKey.RightArrow:
                    xPosition++;
                    FigureExtractor(currentFigure, xPosition, yPosition, filler, figureOrientation, ref DEBUG);
                    break;

                case ConsoleKey.UpArrow:
                    yPosition--;
                    FigureExtractor(currentFigure, xPosition, yPosition, filler, figureOrientation, ref DEBUG);
                    break;

                case ConsoleKey.D5:
                    motionFreezer = !motionFreezer;
                    break;

                case ConsoleKey.Spacebar:
                    figureOrientation = figureOrientation > 3 ? 1 : figureOrientation + 1;
                    FigureExtractor(currentFigure, xPosition, yPosition, filler, figureOrientation, ref DEBUG);
                    break;
            }
        }
    }
}
//Здесь размещаем ресурсы для игры: Массивы фигур, 
using static System.Console;
using System.Linq;
using System;
using static MyLibrary;

public class TetrisSourceLibrary
{
    int figureColorNumber = 2; //задали цвет падающих фигур
    public static void FigureExtractor(int digit, int x, int y, char filler, int figureOrientation, ref bool DEBUG)
    {
        switch (digit)
        {
            case 0:
                FigureRectangle(x, y, filler, digit, figureOrientation);
                break;
            case 1:
                FigureStick(x, y, filler, digit, figureOrientation);
                break;
            case 2:
                FigureL(x, y, filler, digit, figureOrientation, ref DEBUG);
                break;
                /*case 3:
                    FigureStickVertical(x, y, filler, digit);
                    break;
                case 4:
                    FigureStickVertical(x, y, filler, digit);
                    break;
                case 5:
                    FigureStickVertical(x, y, filler, digit);
                    break;
                case 6:
                    FigureStickVertical(x, y, filler, digit);
                    break;
                case 7:
                    FigureStickVertical(x, y, filler, digit);
                    break;
                case 8:
                    FigureStickVertical(x, y, filler, digit);
                    break;
                case 9:
                    FigureStickVertical(x, y, filler, digit);
                    break;
                default:
                    FigureStickVertical(x, y, filler, digit);
                    break;*/
        }
    }


    // Метод формирования массива char из надстрочных или подстрочных символов Unicode
    /// <summary>
    /// 
    /// </summary>
    /// <param name="b">Показатель степени или основания</param>
    /// <param name="selector">Переключатель типов символов. 0 - подстрочный индекс, 1 - надстрочный индекс</param>
    /// <param name="DEBUG">Параметр определяет режим работы программы. 0 - прод, 1 - дебаг</param>
    /// <example>FillOneDimArrayBySubscriptSuperscript(b, selector, DEBUG);</example>
    public static char[,] TetrisForms(int b, int selector, bool DEBUG)
    {
        char[,] figure = new char[5, 5];
        //Здесь должны быть массивы фигур


        return figure;
    }
    public static void FigureRectangle(int x, int y, char filler, int colorNumber, int figureOrientation)
    {
        // Clear();
        ChangeForegroundColor(colorNumber);
        //Горизонтальная ориентация
        if (figureOrientation % 2 == 0)
        {
            for (int i = x - 4; i <= x + 4; i++)
            {
                for (int j = y - 1; j <= y + 1; j++)
                {
                    SetCursorPosition(i, j);
                    Write(filler);
                }
            }
        }
        else
        {
            //Вертикальная ориентация
            for (int i = x - 2; i <= x + 2; i++)
            {
                for (int j = y - 1; j <= y + 2; j++)
                {
                    SetCursorPosition(i, j);
                    Write(filler);
                }
            }
        }
    }
    public static void FigureStick(int x, int y, char filler, int colorNumber, int figureOrientation)
    {
        ChangeForegroundColor(colorNumber);
        if (figureOrientation % 2 == 0)
        {
            //Горизонтальная ориентация
            for (int i = x - 5; i <= x + 5; i++)
            {
                SetCursorPosition(i, y);
                Write(filler);
            }
        }
        else
        {
            //Вертикальная ориентация
            for (int i = x - 1; i <= x + 1; i++)
            {
                for (int j = y - 1; j <= y + 3; j++)
                {
                    SetCursorPosition(i, j);
                    Write(filler);
                }
            }
        }

    }
    public static void FigureL(int x, int y, char filler, int colorNumber, int figureOrientation, ref bool DEBUG)
    {
        ChangeForegroundColor(colorNumber);
        switch (figureOrientation)
        {
            case 1:
                // ^ ориентация

                for (int i = x - 1; i <= x + 3; i++)
                {
                    for (int j = y - 1; j < y; j++)
                    {
                        SetCursorPosition(i, j);
                        Write(filler);
                    }
                }
                for (int i = x - 1; i <= x + 1; i++)
                {
                    for (int j = y; j <= y + 4; j++)
                    {
                        SetCursorPosition(i, j);
                        Write(filler);
                    }
                }
                break;
            case 2:
                // < ориентация
                for (int i = x - 1; i <= x + 1; i++)
                {
                    for (int j = y - 1; j <= y + 2; j++)
                    {
                        SetCursorPosition(i, j);
                        Write(filler);
                    }
                }
                for (int i = x - 1; i <= x + 3; i++)
                {
                    for (int j = y + 3; j < y + 4; j++)
                    {
                        SetCursorPosition(i, j);
                        Write(filler);
                    }
                }
                break;

            case 3:
                // v ориентация
                for (int i = x - 1; i <= x + 1; i++)
                {
                    for (int j = y - 1; j <= y + 3; j++)
                    {
                        SetCursorPosition(i, j);
                        Write(filler);
                    }
                }
                for (int i = x - 3; i <= x + 1; i++)
                {
                    for (int j = y + 3; j < y + 4; j++)
                    {
                        SetCursorPosition(i, j);
                        Write(filler);
                    }
                }
                break;

            case 4:
                // > ориентация
                for (int i = x - 3 ; i <= x + 1; i++)
                {
                    for (int j = y - 1; j < y; j++)
                    {
                        SetCursorPosition(i, j);
                        Write(filler);
                    }
                }
                for (int i = x - 1; i <= x + 1; i++)
                {
                    for (int j = y; j <= y + 4; j++)
                    {
                        SetCursorPosition(i, j);
                        Write(filler);
                    }
                }
                break;
        }
    }
}

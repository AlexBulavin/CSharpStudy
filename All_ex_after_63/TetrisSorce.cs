//Здесь размещаем ресурсы для игры: Массивы фигур, 
using static System.Console;
using System.Linq;
using System;
using static MyLibrary;

public class TetrisSourceLibrary
{
    int colorNumber = 4;//задали цвет падающих фигур
    public static void FigureExtractor(int digit, int x, int y, char filler, int colorNumber)
    {
        switch (digit)
        {
            case 0:
                FigureRectangleVertical(x, y, filler, colorNumber);
                break;
            case 1:
                FigureRectangleHorizontal(x, y, filler, colorNumber);
                break;
            case 2:
                FigureStickHorizontal(x, y, filler, colorNumber);
                break;
            case 3:
                FigureStickVertical(x, y, filler, colorNumber);
                break;
            case 4:
                FigureStickVertical(x, y, filler, colorNumber);
                break;
            case 5:
                FigureStickVertical(x, y, filler, colorNumber);
                break;
            case 6:
                FigureStickVertical(x, y, filler, colorNumber);
                break;
            case 7:
                FigureStickVertical(x, y, filler, colorNumber);
                break;
            case 8:
                FigureStickVertical(x, y, filler, colorNumber);
                break;
            case 9:
                FigureStickVertical(x, y, filler, colorNumber);
                break;
            default:
                FigureStickVertical(x, y, filler, colorNumber);
                break;
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
    public static void FigureRectangleVertical(int x, int y, char filler, int colorNumber)
    {
        Clear();
        ChangeForegroundColor(colorNumber);
        for (int i = x - 2; i <= x + 2; i++)
        {
            for (int j = y - 1; j <= y + 5; j++)
            {
                SetCursorPosition(i, j);
                Write(filler);
            }
        }
    }

    public static void FigureRectangleHorizontal(int x, int y, char filler, int colorNumber)
    {
        Clear();
        ChangeForegroundColor(colorNumber);
        for (int i = x - 5; i <= x + 5; i++)
        {
            for (int j = y - 1; j <= y + 2; j++)
            {
                SetCursorPosition(i, j);
                Write(filler);
            }
        }
    }

    public static void FigureStickHorizontal(int x, int y, char filler, int colorNumber)
    {
        Clear();
        ChangeForegroundColor(colorNumber);

        for (int i = x - 5; i <= x + 5; i++)
        {
            SetCursorPosition(i, y);
            Write(filler);
        }
    }

    public static void FigureStickVertical(int x, int y, char filler, int colorNumber)
    {
        Clear();
        ChangeForegroundColor(colorNumber);
        for (int i = y - 1; i <= y + 10; i++)
        {
            SetCursorPosition(x, i);
            Write(filler);
        }
    }

}
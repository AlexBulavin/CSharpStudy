using static MyLibrary123;
using static System.Console;

public class Ex_64_Pascal
{
    public static void Task64()
    {
        Console.Clear();
        //Здесь пишем весь код по задаче
        //1. Создаём массив
        //2. Заполняем его элементами
        //3. Выводим на печать

        //1. Создаём 2D int массив
        // Console.ForegroundColor = ConsoleColor.Blue;
        // WriteLine($"Создаём массив размерностью в ширину консоли = {Console.WindowWidth / 2 * 2 + 1}");
        // Console.ResetColor();
        uint[] array = CreateArrayUint(21);
        FillIntZero(array);
        array[9] = 1;

        //2. Заполняем его элементами и выводим в цикле нужное количество раз (строк)
        for (int i = 0; i < 15; i++)
        {
            WriteLine(FillPascalTriangle(array, 1));
            WriteLine();
        }
/*
        string output = FillPascalTriangle(array, 1);

        //3. Выводим на печать c цветом
        for (int i = 0; i < output.Length; i++)
        {
            //(int)Char.GetNumericValue(osBaseLocal[i])
            if (String.Equals(output[i], "0"))
            {
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            if ((int)Char.GetNumericValue(output[i]) % 2 == 0 & String.Equals(output[i], "0"))
            {
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            Write(output[i]);
            Console.ResetColor();
        }*/
    }
}
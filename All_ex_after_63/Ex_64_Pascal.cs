using static MyLibrary123;
using static System.Console;

public class Ex_64_Pascal
{
    public static void Task64()
    {
        bool DEBUG = false;//true;//Включение/отключение дебаг режима
        Console.Clear();
        //Здесь пишем весь код по задаче
        //1. Создаём массив
        //2. Заполняем его элементами
        //3. Выводим на печать

        //1. Создаём 2D uint массив
        // Console.ForegroundColor = ConsoleColor.Blue;
        // WriteLine($"Создаём массив размерностью в ширину консоли = {Console.WindowWidth / 2 * 2 + 1}");
        // Console.ResetColor();
        int triangleSize = 30, interval, halfSize = triangleSize / 2;
        uint[] array = CreateArrayUint(triangleSize);

        interval = 8;
        PrefillArray(array, interval, DEBUG);

        //2. Заполняем его элементами и выводим в цикле triangleSize/2 количество раз (строк)
        for (int i = 0; i < array.Length / 2; i++)
        {
            WriteLine(FillPascalTriangle(array, interval, i + 2, DEBUG));
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
internal static class ConsoleHelper
{
    public static int ReadNumber(string prompt, Predicate<int> condition, string errorMessage)
    {
        int result;
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out result) && condition(result))
                break;
            Console.WriteLine(errorMessage);
        }
        return result;
    }
}

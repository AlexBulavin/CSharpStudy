using static MyLibrary;
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
        int  triangleHeight= Input("Ошибка, введено не целое число", "Введите высоту пирамиды в целых строках, например, 5: ", DEBUG), interval, triangleSize = triangleHeight * 2;
        uint[] array = CreateArrayUint(triangleSize + 4);

        interval = ((triangleSize + 4)- 5)/3 + 1;
        

        //По размеру пирамиды
        //Количество строк / максимальная размерность элементов 
        // 1 до 5 = 1 знак
        // + 3 5 до 9 2 знака
        // +3 10 до 13 3 знака
        // +3 14 до 16 4 знака
        // +3 17 до 20 5 знаков
        //+3 21 до 24 6 знаков
        //+3 25 до 28 7 знаков
        //...
        PrefillArray(array, interval, DEBUG);

        //2. Заполняем его элементами и выводим в цикле triangleSize/2 количество раз (строк)
        for (int i = 0; i < array.Length / 2; i++)
        {
            //WriteLine(FillPascalTriangle(array, interval, i + 2, DEBUG));
            string output = FillPascalTriangle(array, interval, i + 2, DEBUG);
            WriteLine();
        }
        WriteLine("\n\n\n");

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

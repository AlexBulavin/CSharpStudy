//63. Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента
using static MyLibrary123;
using static System.Console;

// 0. Метод ввода размерности трехмерного массива от пользователя
// 1. Метод заполняет и выводит построчно исходный массив неповторяющимися целыми числами (от 10 до 99)
// 2. Метод выводит исходный массив построчно


public static class Seminar62
{

    public static void Main()
    {
        bool debug = false;
        int columnsInArray = 89;
        int listsInArray = 89;
        Clear();
        // 0. Метод ввода размерности двумерного массива от пользователя
        int rowsInArray = Input("Введите количество строк массива (общая размерность массива arr[K, M, N] KxMxN не должен превышать 90)): ");
        while (89 / (rowsInArray * columnsInArray) < 1)
        {
            columnsInArray = Input($"Введите количество столбцов массива (число должно быть не больше {88 / rowsInArray}): ");
        }
        while (88 / (rowsInArray * columnsInArray * listsInArray) < 1)
        {
            listsInArray = Input($"Введите количество слоёв массива (число должно быть не больше {88 / (rowsInArray * columnsInArray)}): ");
        }
        int[,,] arr3D = CreateArrayInt3D(listsInArray, rowsInArray, columnsInArray);

        // 1. Метод заполняет и выводит построчно исходный массив неповторяющимися целыми числами (от 10 до 99)
        FillRandInt3D(arr3D);
        WriteLine();
        WriteLine(PrintGood3DInt(arr3D, 1));
    }
}

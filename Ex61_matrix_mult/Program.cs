//Найти произведение двух матриц

//с н виноградов и а ф кузьмин логика
//https://www.google.com/search?client=safari&rls=en&q=%D0%B0%D0%BB%D0%B5%D0%BA%D1%81%D0%B0%D0%BD%D0%B4%D1%80+%D1%88%D0%B5%D0%BD%D1%8C+%D0%BF%D1%80%D0%BE%D0%B3%D1%80%D0%B0%D0%BC%D0%BC%D0%B8%D1%80%D0%BE%D0%B2%D0%B0%D0%BD%D0%B8%D0%B5+%D1%82%D0%B5%D0%BE%D1%80%D0%B5%D0%BC%D1%8B+%D0%B8+%D0%B7%D0%B0%D0%B4%D0%B0%D1%87%D0%B8&ie=UTF-8&oe=UTF-8
//Структуры данных и алгоритмы | Ульман Джеффри Д., Хопкрофт Джон Э.
//Дональд Кнутт Искусство программирования
using static MyLibrary123;
using static System.Console;

// 0. Метод ввода размерности матриц от пользователя
// 1. Метод создания двух матриц
// 2. Метод заполняет исходные матрицы 
// 3. Метод выводит исходные матрицы 
// 4. Метод заполняет результирующую матрицу
// 5. Метод выводит результирующую матрицу

public static class Seminar61
{
    public static void Main()
    {
        Clear();
        // 0. Метод считывания размерности матриц от пользователя
        int size1_0 = Input("Введите количество строк первой матрицы:");
        int size1_1 = Input("Введите количество столбцов первой матрицы:");
        //int size2_0 = Input("Введите количество строк второй матрицы:");
        int size2_1 = Input("Введите количество столбцов второй матрицы:");

        // 1. Метод создания двух исходных и результирующей матриц
        int[,] array1 = CreateArrayIntTwo(size1_0, size1_1); //Создали первый массив
        int[,] array2 = CreateArrayIntTwo(size1_1, size2_1); //Создали второй массив
        int[,] resArray = CreateArrayIntTwo(size1_1, size2_1); //Создали второй массив

        // 2. Метод заполняет исходные матрицы 
        //Задаём границы для рандомайзера и параметр включения граничного значения
        int min = 0;
        bool minInclude = true;
        int max = 100;
        bool maxInclude = true;
        //Заполняем матрицы
        FillRandIntTwo(array1, min, minInclude, max, maxInclude);
        FillRandIntTwo(array2, min, minInclude, max, maxInclude);

        // 4. Метод заполняет результирующую матрицу
        NewMethod(size1_1, size2_1, array1, array2, resArray);
        WriteLine();

    }
    static void NewMethod(int size1_1, int size2_1, int[,] array1, int[,] array2, int[,] resArray)
    {
        for (int i = 0; i < size1_1; i++)
        {
            for (int j = 0; j < size2_1; j++)
            {
                for (int m = 0; m < Math.Min(size1_1, size2_1); m++)
                    resArray[i, j] += array1[i, m] * array2[m, j];
                Write(resArray[i, j] + "\t");
            }
            WriteLine();
        }
    }
}


/*using System;
 
namespace ConsoleApplication1
{
    class Program
    {
        Random r = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность первой матрицы: ");
            int[,] A = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A[i, j] = r.Next(10, 120);
                }
            }
            Console.WriteLine("Введите размерность второй матрицы: ");
            int[,] B = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    B[i, j] = r.Next(30, 50);
                }
            }
 
            Console.WriteLine("\nМатрица A:");
            Print(A);
            Console.WriteLine("\nМатрица B:");
            Print(B);
            Console.WriteLine("\nМатрица C = A * B:");
            int[,] C = Multiplication(A, B);
            Print(C);
 
        }
        static int[,] Multiplication(int[,] a, int[,] b)
        {
            if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
            int[,] r = new int[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int k = 0; k < b.GetLength(0); k++)
                    {
                        r[i,j] += a[i,k] * b[k,j];
                    }
                }
            }
            return r;
        }
        static void Print(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("{0} ", a[i, j]);
                }
                Console.WriteLine();
            }
        }
    } 
}
*/

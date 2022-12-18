using static MyLibrary;
using static System.Console;

public class Spyral
{
    public static void Matrix1()
    {
        //Спирально заполнить двумерный массив
        bool DEBUG = false;//true;//
        Console.Clear();
        int j, i, N;
        N = Input("Введите размер массива arrSize ");

        int[,] arr = CreateArrayIntTwo(N, N);
        FillRandIntTwo(arr, 0, true, 0, true);
        PrintGoodTwo(arr, 1);
        //Алгоритм отсюда: https://habr.com/ru/post/560266/
        for (int ik = 0; ik < N; ik++)
        {     //назовем его "Основной цикл"
            for (int jk = 0; jk < N; jk++)
            {
                i = ik + 1;     // Номера строк и столбцов приводим в удобный
                j = jk + 1;     // в математическом плане вид (от 1 до N)  
                //Здесь будем вставлять основной код вычислений
                int switcher = (j - i + N) / N;//Переключатель для смены логики кусочно-непрерывной функции при обходе по периметру каждой стороны матрицы для двух участков
                                               //1.    ai,j = Xs = i + j - 1; действует от [1, 1] до [N, N].
                                               //2.    ai,j = 4*N – 2 - X; действует от [N, N] до [2, 1].
                int Ic = Math.Abs(i - N / 2 - 1) + (i - 1) / (N / 2) * ((N - 1) % 2);
                int Jc = Math.Abs(j - N / 2 - 1) + (j - 1) / (N / 2) * ((N - 1) % 2);
                int Ring = N / 2 - (Math.Abs(Ic - Jc) + Ic + Jc) / 2;
                int Xs = i - Ring + j - Ring - 1;
                int Coef = 4 * Ring * (N - Ring);
                if ((ik == 0 | ik == N - 1 | jk == 0 | jk == N - 1))
                {
                    Xs = i + j - 1;
                    arr[ik, jk] = switcher * Xs + Math.Abs(switcher - 1) * (4 * N - 2 - Xs);// Временное условие для фильтрации элементов внешнего "кольца"  
                }

                else
                    arr[ik, jk] = Coef + switcher * Xs + Math.Abs(switcher - 1) * (4 * (N - 2 * Ring) - 2 - Xs);
                Write($"{arr[ik, jk]}\t");
            }
            WriteLine();
        }
        WriteLine("\n");

        //arr[ik]



    }
}
// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
using static MyLibrary;
using static System.Console;
Console.Clear();

int m = Input("Введите количество строк двумерного массива: ");
int n = Input("Введите количество столбцов двумерного массива: ");
int[,] arr = CreateArrayIntTwo(m, n);
bool trigger = false;


//Заполняем массив случайными числами. Если i и j чётные, то квадратами.
FillRandIntTwo(arr, 10, true, 99, true);
Write(PrintGoodTwo(arr,1));

int number = Input("Задайте число, которое нужно найти в массиве:");

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (arr[i, j] == number)
        {
            WriteLine($"Самый первый встретившийся элемент {arr[i, j]} найден, имеет индексы [{i}, {j}] \n");
            trigger = true;
            break;
            
        }   
        if (trigger) break;
    }   
    if (trigger) break;
}
if (!trigger) WriteLine($"\nЭлемент {number} не найден\n");

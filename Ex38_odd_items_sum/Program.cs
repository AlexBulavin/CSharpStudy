//Найти сумму чисел одномерного массива стоящих на нечетной позиции
using static MyLibrary123;
using static System.Console;

bool DEBUG = false;
// 0. Задать массив
// 1. заполнить случайными числами -100 ... +100
// 2. Подсчитать сумму нечетных элементов
// 3. Вывести на экран массив и сумму нечётных элементов

// 0. Задать массив
int[] arr = CreateArrayInt(Input("\nЗадайте размерность массива: "));
int[] count = CreateArrayInt(2);//Суммы чётных и нечётных чисел
int interval = 1;
bool evenOdd = false;//true - сумматор чётных элементов, false - нечётных

// 1. заполнить случайными числами и вывести массив на печать
WriteLine(FillRandIntSum(arr, - 100, true, 100, true, count, DEBUG, interval));
if (DEBUG) WriteLine($"Line 19 {count[0]} {count[1]}");
WriteLine();

// 2. Показать количество нечетных/четных чисел
Write($"Сумма {(evenOdd ? "чётных": "нечётных")} элементов = {(evenOdd ? count[0] : count[1])}\n");
WriteLine();

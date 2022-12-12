//Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
//git push https://ghp_bA2****************3vtX0M@github.com/AlexBulavin/CSharpStudy.git
using static MyLibrary123;
using static System.Console;

bool DEBUG = false;
// 0. Задать массив
// 1. заполнить случайными положительными трёхзначными числами
// 2. Показать количество нечетных\четных чисел

// 0. Задать массив
int[] arr = CreateArrayInt(Input("\nЗадайте размерность массива: "));
int[] count = CreateArrayInt(2);//Чётные числа, Нечётные числа

// 1. заполнить случайными положительными трёхзначными числами
FillCheckPrintRandInt(arr, count, DEBUG);
if (DEBUG) WriteLine($"Line 16 {count[0]} {count[1]}");
WriteLine();

//1.1 Распечатать массив
WriteLine(PrintGood(arr, 1));
WriteLine();

// 2. Показать количество нечетных/четных чисел
Write($"В массиве {count[0]} чётных и {count[1]} нечётных чисел\n");
WriteLine();

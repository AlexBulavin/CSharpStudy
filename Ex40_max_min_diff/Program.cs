//В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
//git push https://ghp_bA2****************3vtX0M@github.com/AlexBulavin/CSharpStudy.git
using static MyLibrary123;
using static System.Console;

bool DEBUG = false;
// 0. Задать массив
// 1. заполнить случайными числами -100 ... +100
// 2. Подсчитать сумму нечетных элементов
// 3. Вывести на экран массив и сумму нечётных элементов

float[] arr = CreateArrayFloat(Input("\nЗадайте размер массива: "));
float[] count = CreateArrayFloat(2);
int interval = 1;


//Заполняем массив рандомными числами от 0 до 99
WriteLine(FillRandFloatDiff(arr, 0, true, 1000, true, count, DEBUG, interval));
WriteLine($"\nРазница между максимальным {count[1]} и минимальным {count[0]} значениями равна {count[1] - count[0]}");

Console.Write("\n");

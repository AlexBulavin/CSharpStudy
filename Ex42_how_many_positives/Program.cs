//Определить сколько чисел больше 0 введено с клавиатуры
//git push https://ghp_bA2****************3vtX0M@github.com/AlexBulavin/CSharpStudy.git
using static System.Console;

int number;
int positive = 0;
ConsoleKey key = default(ConsoleKey);
Console.Clear();
while (true)
{
    if (key != ConsoleKey.Q | key != ConsoleKey.Escape )
    {//Пока не нажата клавиша Q считываем числа
        Write("\nВведите число или Q или Escape для подсчёта положительных значений и завершения работы программы");
        number = Convert.ToInt32(Console.ReadLine());
        if (number > 0)
        {
            positive++;
        }
        WriteLine($"Количество положительных чисел = {positive}");
    }
    else break;
}
Console.Write("\n");

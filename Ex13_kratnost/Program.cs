﻿// Выяснить, кратно ли число заданному, если нет, вывести остаток.
//git push https://ghp_bA2****************3vtX0M@github.com/AlexBulavin/CSharpStudy.git  

Console.Write("\nВведите число, которое проверяем на кратность: "); //Запрашиваем у пользователя 1 число. Проверку не производим (пока)
int N1 = Convert.ToInt32(Console.ReadLine()); //Читаем и преобразуем строку в Int 32

Console.Write("\nВведите число, на которое делим  : "); //Запрашиваем у пользователя 1 число. Проверку не производим (пока)
int N2 = Convert.ToInt32(Console.ReadLine()); //Читаем и преобразуем строку в Int 32

if (N1 > N2) {
    if ((double)N1/(double)N2 - N1/N2 > 0)
    {
        Console.WriteLine("Первое число не кратно второму, остаток от деления = " + (N1 - N1/N2*N2));
    }
}

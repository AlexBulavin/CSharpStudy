﻿// Дано число обозначающее день недели. Выяснить является номер дня недели выходным 
Console.Write("\nВведите номер дня недели: "); //Запрашиваем у пользователя 1 число. Проверку не производим (пока)
int weekDay = Convert.ToInt32(Console.ReadLine()); //Читаем и преобразуем строку в int

Console.WriteLine(weekDay == 6 | weekDay == 7 ? "Выходной\n" : "Рабочий день\n");

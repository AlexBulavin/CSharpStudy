//git push https://ghp_bA2****************3vtX0M@github.com/AlexBulavin/CSharpStudy.git  

//Написать программу вычисления значения функции y = f(a)

Console.Write("\nВведите аргумент для функции sin(a) в формате -360 ... 360 :"); //Запрашиваем у пользователя 1 число. Проверку не производим (пока)
int y = Convert.ToInt32(Console.ReadLine()); //Читаем и преобразуем строку в double

Console.Write("SIN(" + y.ToString() + ") = " + Math.Sin(y).ToString() + "\n");

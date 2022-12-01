//git push https://ghp_bA2****************3vtX0M@github.com/AlexBulavin/CSharpStudy.git  

//Выяснить является ли число чётным

Console.Write("\nВведите натуральное число :"); //Запрашиваем у пользователя 1 число. Проверку не производим (пока)
int N = Convert.ToInt32(Console.ReadLine()); //Читаем и преобразуем строку в Int 32

Console.Write(N % 2 == 0 ? "Число чётное\n" : "Число нечётное\n");

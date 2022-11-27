//git push https://ghp_bA2****************3vtX0M@github.com/AlexBulavin/git_lesson_3.git 
//По двум заданным числам проверять является ли первое квадратом второго

Console.Write("\nВведите первое целое число: "); //Запрашиваем у пользователя 1 число. Проверку не производим (пока)
int number1 = Convert.ToInt32(Console.ReadLine()); //Читаем и преобразуем строку в int
Console.Write("Введите второе целое число: "); //Запрашиваем у пользователя 2 число. Проверку не производим (пока)
int number2 = Convert.ToInt32(Console.ReadLine()); //Читаем и преобразуем строку в int

Console.WriteLine(Convert.ToInt32(Math.Pow(number1, 2)) == number2 | Convert.ToInt32(Math.Pow(number2, 2)) == number1 ? "Одно число является квадратом другого\n" : "Ни одно число не является квадратом другого\n");
//Делаем конкатенацию с приведением типа вычислений сначала к int, а далее к string


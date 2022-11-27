//git push https://ghp_bA2****************3vtX0M@github.com/AlexBulavin/git_lesson_3.git 
//По двум заданным числам проверять является ли первое квадратом второго

Console.Write("\nВведите первое целое число: "); //Запрашиваем у пользователя 1 число. Проверку не производим (пока)
int number1 = Convert.ToInt32(Console.ReadLine()); //Читаем и преобразуем строку в int
Console.Write("Введите второе целое число: "); //Запрашиваем у пользователя 2 число. Проверку не производим (пока)
int number2 = Convert.ToInt32(Console.ReadLine()); //Читаем и преобразуем строку в int

Console.WriteLine(number1 > number2 ? number1.ToString() + " > " + number2.ToString() : number1 < number2 ? number1.ToString() + " < " + number2.ToString() + "\n" : number1.ToString() + " = " + number2.ToString() + "\n");
//Делаем конкатенацию с приведением типа вычислений сначала к int, а далее к string

// AlexBulavin
//Вывести квадрат числа

Console.Write("\nВведите целое число: "); //Запрашиваем у пользователя число. Проверку не производим (пока)
int number = Convert.ToInt32(Console.ReadLine()); //Читаем и преобразуем строку в int
Console.WriteLine(number.ToString() + " ^ 2 = " + Convert.ToInt32(Math.Pow(number, 2)).ToString()+ "\n");//Делаем конкатенацию с приведением 
//типа вычислений сначала к int, а далее к string
//git push https://ghp_bA2Jdo5tWsC5u7JSZjdkрH58ULs5vceK3vtX0M@github.com/AlexBulavin/git_lesson_3.git 

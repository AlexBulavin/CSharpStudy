// Задать номер четверти, показать диапазоны для возможных координат
////git push https://ghp_bA2****************3vtX0M@github.com/AlexBulavin/CSharpStudy.git
Console.WriteLine("\nВведите номер четверти для декартовой плоскости. от 1 до 4");
int Dot = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Dot == 1 ? "0 < X < " + (char)8734 + ", 0 < Y < " + (char)8734 : 
 Dot == 2 ? "0 < X < " + (char)8734 + ", -" + (char)8734 + " < Y < 0" : 
 Dot == 3 ? "-" + (char)8734 + " Х < 0, -" + (char)8734 + "Y < 0" : 
 Dot == 4 ? "- " + (char)8734 + "Х < 0, 0 < Y " + (char)8734 :
 "Введено неправильное значение"
 );

// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
////git push https://ghp_bA2****************3vtX0M@github.com/AlexBulavin/CSharpStudy.git
Console.WriteLine("\nВведите координаты X, Y. \nНапример: -2,5 Enter \n8,7");
double[] Dot = {Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())};

Console.WriteLine(Dot[0] > 0 & Dot[1] > 0 ? "Квадрант 1 Х > 0, Y > 0" : 
 Dot[0] > 0 & Dot[1] < 0 ? "Квадрант 2 Х > 0, Y < 0" : 
 Dot[0] < 0 & Dot[1] < 0 ? "Квадрант 3 Х < 0, Y < 0" : 
 Dot[0] < 0 & Dot[1] > 0 ? "Квадрант 4 Х < 0, Y > 0" :
 "Введены неправильные значения"
 );


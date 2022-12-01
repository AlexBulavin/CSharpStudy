//Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
Console.Write("Введите коэффициенты первой прямой. k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффициенты второй прямой. k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());
double y = (b2-b1)/(k1-k2);
double x = (y-b1)/k1;

Console.WriteLine("Координаты пересечения Х = " + x + " Y = " + y);

//Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
using static System.Console;
using static MyLibrary;

double k1 = Input("Введите коэффициенты первой прямой. k1 = ", true);
double b1 = Input("b1 = ", true);
double k2 = Input("Введите коэффициенты второй прямой. k2 = ", true);
double b2 = Input("b2 = ", true);
double y = (b2-b1)/(k1-k2);
double x = (y-b1)/k1;

WriteLine($"\nКоординаты пересечения Х = {x} Y = {y}\n");

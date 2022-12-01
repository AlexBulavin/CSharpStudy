//Написать программу масштабирования фигуры
Console.Write("Введите координаты трёх точек. X1, Y1, X2, Y2, X3, Y3 = ");
double[] startCoordinate = new double[6]{Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())};
Console.Write("Введите коэффициент мсштабирования = ");
double k = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Новые координаты фигуры:");
for (int i = 0; i < 6; i++)
{
    Console.Write(startCoordinate[i] * k + "\t");
}
Console.Write("\n");

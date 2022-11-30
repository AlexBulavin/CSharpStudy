// Показать таблицу квадратов чисел от 1 до N 
Console.Write("\nВведите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

for (int i = 1; i <= N; i++)
{
    Console.Write("|   " + i + "\t");
}
Console.WriteLine("");
for (int i = 1; i <= N; i++)
{
    Console.Write("--------");
}
Console.WriteLine("");
for (int i = 1; i <= N; i++)
{
    Console.Write("|   " + i*i + "\t");
}
Console.WriteLine("");
Console.WriteLine("");

// Найти кубы чисел от 1 до N
//git push https://ghp_bA2****************3vtX0M@github.com/AlexBulavin/CSharpStudy.git
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
    Console.Write("|   " + i*i*i + "\t");
}
Console.WriteLine("\n");

// See Найти сумму чисел от 1 до А
//git push https://ghp_bA2****************3vtX0M@github.com/AlexBulavin/CSharpStudy.git
Console.Write("\nВведите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;
Console.WriteLine("");

for (int i = 1; i <= N; i++)
{
    sum +=i;
}
Console.WriteLine("sum = " + sum + "\n");

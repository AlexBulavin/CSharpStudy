//git push https://ghp_bA2****************3vtX0M@github.com/AlexBulavin/CSharpStudy.git  
//Показать числа от -N до N

Console.Write("\nВведите натуральное число :"); //Запрашиваем у пользователя 1 число. Проверку не производим (пока)
int N = Convert.ToInt32(Console.ReadLine()); //Читаем и преобразуем строку в Int 32

for (int i = - N; i <= N; i++)
{

    Console.WriteLine(i);
}
// Показать вторую цифру трёхзначного числа
//git push https://ghp_bA2****************3vtX0M@github.com/AlexBulavin/CSharpStudy.git  

Console.Write("\nВведите натуральное трёхзначное число :"); //Запрашиваем у пользователя 1 число. Проверку не производим (пока)
int N = Convert.ToInt32(Console.ReadLine()); //Читаем и преобразуем строку в Int 32

if (N >= 100) {
      Console.WriteLine((N%100 - N%10)/10);
}
else 
{
    Console.WriteLine("N < 100");
}
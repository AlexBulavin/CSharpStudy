// Показать четные числа от 1 до N
//git push https://ghp_bA2****************3vtX0M@github.com/AlexBulavin/CSharpStudy.git  

//Показать четные числа от 1 до N

Console.Write("\nВведите натуральное число :"); //Запрашиваем у пользователя 1 число. Проверку не производим (пока)
int N = Convert.ToInt32(Console.ReadLine()); //Читаем и преобразуем строку в Int 32

if (N >= 2) {
  for (int i = 2; i <= N; i +=2) {
      Console.WriteLine(i);
  }

}
else 
{
    Console.WriteLine("N < 2");
};
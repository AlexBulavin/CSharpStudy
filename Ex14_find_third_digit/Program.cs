// Найти третью цифру числа или сообщить, что её нет
//git push https://ghp_bA2****************3vtX0M@github.com/AlexBulavin/CSharpStudy.git  

Console.Write("\nВведите натуральное число : "); //Запрашиваем у пользователя 1 число. Проверку не производим (пока)
int N = Convert.ToInt32(Console.ReadLine()); //Читаем и преобразуем строку в Int 32

if (N >= 100) {
    Console.WriteLine($"Третья цифра числа {N} = {N /100}");
}
else 
{
    Console.WriteLine($"Третьей цифры в числе {N} нет\n");
}
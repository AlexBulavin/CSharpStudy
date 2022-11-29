//Дано число. Проверить кратно ли оно 7 и 23
//git push https://ghp_bA2****************3vtX0M@github.com/AlexBulavin/CSharpStudy.git  

Console.Write("\nВведите число, которое проверяем на кратность: "); //Запрашиваем у пользователя 1 число. Проверку не производим (пока)
int N = Convert.ToInt32(Console.ReadLine()); //Читаем и преобразуем строку в Int 32

if (N >= 7 * 23) 
{
    if ((double)N/7 - N/7 > 0 | (double)N/23 - N/23 > 0)
    {
        Console.WriteLine("Первое число не кратно 7 и 23\n");
    }
    else Console.WriteLine("Число " + N + " кратно 7 и 23\n");
}
else {Console.WriteLine("Первое число не кратно 7 и 23\n");}

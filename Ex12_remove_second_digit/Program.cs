// Удалить вторую цифру трёхзначного числа
//git push https://ghp_bA2****************3vtX0M@github.com/AlexBulavin/CSharpStudy.git  

Console.Write("\nВведите натуральное трёхзначное число : "); //Запрашиваем у пользователя 1 число. Проверку не производим (пока)
int N = Convert.ToInt32(Console.ReadLine()); //Читаем и преобразуем строку в Int 32

if (N >= 100) {
    int dig1 = N % 10;
    int dig2 = (N%100 - dig1)/10;
    Console.WriteLine(N - dig2*10);
    Console.WriteLine(N/10 -dig2 + dig1);
}
else 
{
    Console.WriteLine("N < 100");
}
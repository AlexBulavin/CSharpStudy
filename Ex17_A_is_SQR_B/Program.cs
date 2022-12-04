// По двум заданным числам проверять является ли одно квадратом другого
//git push https://ghp_bA2****************3vtX0M@github.com/AlexBulavin/CSharpStudy.git
Console.Write("\nВведите X : "); //Запрашиваем у пользователя X число. Проверку не производим (пока)
double N1 = Convert.ToDouble(Console.ReadLine()); //Читаем и преобразуем строку в int
Console.Write("\nВведите Y: "); //Запрашиваем у пользователя 2 число. Проверку не производим (пока)
double N2 = Convert.ToDouble(Console.ReadLine()); //Читаем и преобразуем строку в int

Console.Write(N1 == N2*N2 ? N1 + " = " + N2 + " * " + N2 + "\n\n" : N2 == N1*N1 ? N2 + " = " + N1 + " * " + N1 + "\n\n" : "Ни одно из чисел не является квадратом другого\n\n");
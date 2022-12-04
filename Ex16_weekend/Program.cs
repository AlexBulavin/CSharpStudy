// Дано число обозначающее день недели. Выяснить является номер дня недели выходным 
//git push https://ghp_bA2****************3vtX0M@github.com/AlexBulavin/CSharpStudy.git
int weekDay = -1;
while (weekDay < 1 | weekDay >7)
{
Console.Write("\nВведите номер дня недели от 1 (пнд) до 7 (воскр): "); //Запрашиваем у пользователя 1 число. Проверку не производим (пока)
weekDay = Convert.ToInt32(Console.ReadLine()); //Читаем и преобразуем строку в int
}
Console.WriteLine(weekDay == 6 | weekDay == 7 ? "Выходной\n" : "Рабочий день\n");

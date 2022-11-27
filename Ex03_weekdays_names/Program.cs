//git push https://ghp_bA2****************3vtX0M@github.com/AlexBulavin/git_lesson_3.git  CSharpStudy

//По заданному номеру дня недели вывести его название

Console.Write("\nВведите номер дня недели: "); //Запрашиваем у пользователя 1 число. Проверку не производим (пока)
int weekDay = Convert.ToInt32(Console.ReadLine()); //Читаем и преобразуем строку в int

Console.WriteLine(weekDay == 1 ? "Понедельник\n" : 
    weekDay == 2 ? "Вторник\n" : 
    weekDay == 3 ? "Среда\n" :
    weekDay == 4 ? "Четверг\n" :
    weekDay == 5 ? "Пятница\n" :
    weekDay == 6 ? "Суббота\n" :
    weekDay == 7 ? "Воскресенье\n"
    : "Введен ошибочный номер дня недели\n"
    );
//Делаем конкатенацию с приведением типа вычислений сначала к int, а далее к string

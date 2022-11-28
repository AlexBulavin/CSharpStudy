//git push https://ghp_bA2****************3vtX0M@github.com/AlexBulavin/CSharpStudy.git  

//Найти максимальное из трех чисел

int [] numbers = new int[3];;

for (int i = 0; i < 3; i++)
{
    Console.Write("\nВведите " + (i+1).ToString() + " число: "); //Запрашиваем у пользователя 1 число. Проверку не производим (пока)
        numbers[i] = Convert.ToInt32(Console.ReadLine()); //Читаем и преобразуем строку в int
};

Console.Write("Максимальное значение из " + String.Join(", ", numbers) + " = " + numbers.Max().ToString() + "\n");
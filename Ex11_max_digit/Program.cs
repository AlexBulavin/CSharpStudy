//git push https://ghp_bA2****************3vtX0M@github.com/AlexBulavin/CSharpStudy.git  

//Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

//Создание объекта для генерации чисел
Random rnd = new Random();
 
//Получить случайное число (в диапазоне от 0 до 10)
int value = rnd.Next(10, 99);

int dig1 = value % 10;
int dig2 = (value - dig1) /10;
Console.WriteLine("\nВыбрано случайное число " + value);
Console.Write("Максимальное значение = ");
Console.WriteLine(dig1 > dig2 ? dig1 : dig2);
Console.WriteLine("\n");
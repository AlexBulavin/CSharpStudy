//Написать программу преобразования десятичного числа в двоичное
Console.Write("Введите десятичное число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число " + number + " в двоичной форме равно " + Convert.ToString(number, 2));

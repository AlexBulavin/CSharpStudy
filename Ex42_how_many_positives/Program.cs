//Определить сколько чисел больше 0 введено с клавиатуры
//git push https://ghp_bA2****************3vtX0M@github.com/AlexBulavin/CSharpStudy.git
int number;
int positive = 0;
ConsoleKey key = default(ConsoleKey);

while (true)
{if(key != ConsoleKey.Q){
Console.Write("\nВведите число ");
number = Convert.ToInt32(Console.ReadLine());
if (number > 0) 
{
    positive++;
}
Console.WriteLine("Количество положительных чисел = " + positive);
} 
else break;
}
Console.Write("\n");

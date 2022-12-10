// Определить количество цифр в числе и найти их сумму
//git push https://ghp_bA2****************3vtX0M@github.com/AlexBulavin/CSharpStudy.git

using static System.Console;
//Вариант 1
Write("\nВведите натуральное число N: ");
string number = Console.ReadLine();
int sum = 0;
for (int i = 0; i < number.Length; i++)
{
    WriteLine($"number[{i}] = {(int)Char.GetNumericValue(number[i])}");
    sum += (int)Char.GetNumericValue(number[i]);
}
WriteLine($"Сумма цифр в числе  вариант 1 {number} = {sum}\n");

//Второй вариант - без использования строк
sum = 0;
//Console.Write("\nВведите натуральное число N: ");
long number2 = Convert.ToInt64(number);
int digits = (int)Math.Log(number2, 10) + 1;
WriteLine($"number = {number2}, digits = {digits}\n");
int dig;
for (int i = 1; i < digits+1; i++)
{
    dig = (int)(number2 % Math.Pow(10, i) / Math.Pow(10, i - 1));

    WriteLine($"number[{i - 1}] = {dig}");
    sum += dig;
}
WriteLine($"Сумма цифр в числе  вариант 2 {number} = {sum}");

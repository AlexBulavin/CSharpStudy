// Определить количество цифр в числе
//git push https://ghp_bA2****************3vtX0M@github.com/AlexBulavin/CSharpStudy.git
Console.Write("\nВведите натуральное число N: ");
string number = Console.ReadLine();
int sum = 0;
for (int i = 0; i < number.Length; i++)
{
    Console.WriteLine("number[" + i + "] = " + (int)Char.GetNumericValue(number[i]));
    sum += (int)Char.GetNumericValue(number[i]);
}
Console.WriteLine("Сумма цифр в числе " + number + " = " + sum);

// Программа проверяет пятизначное число на палиндромом
////git push https://ghp_bA2****************3vtX0M@github.com/AlexBulavin/CSharpStudy.git
Console.WriteLine("введите пятизначное число");
string num = Console.ReadLine();
if (num >= 10000 & nom <= 99999)
{
    string rev = string.Concat(num.Reverse());
    Console.WriteLine(num == rev ? "палиндром" : "не палиндром");
}


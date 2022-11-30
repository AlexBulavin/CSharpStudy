//Написать программу вычисления произведения чисел от 1 до N
//git push https://ghp_bA2****************3vtX0M@github.com/AlexBulavin/CSharpStudy.git
Console.Write("\nВведите натуральное число N: ");
int number = Convert.ToInt32(Console.ReadLine());
int mult = 1;
if (number > 1)
{
    for (int i = 1; i <= number; i++)
    {
        mult *= i;
    }
    Console.WriteLine("Произведения чисел от 1 до " + number + " = " + mult);
}
else
{
    Console.WriteLine("Произведение чисел от 1 до " + number + " = 0");
}


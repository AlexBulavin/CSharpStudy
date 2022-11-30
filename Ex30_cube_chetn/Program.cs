//Показать кубы чисел, заканчивающихся на четную цифру
//git push https://ghp_bA2****************3vtX0M@github.com/AlexBulavin/CSharpStudy.git
Console.Write("\nВведите натуральное число N: ");
int number = Convert.ToInt32(Console.ReadLine());
int cube = 1;
if (number >= 2)
{
    for (int i = 2; i <= number; i+=2)
    {
        cube = i*i*i;
        Console.WriteLine("Куб " + i + " = " + cube);
    }
}
else
{
    Console.WriteLine("Куб " + number + " = " + number * number * number);
}

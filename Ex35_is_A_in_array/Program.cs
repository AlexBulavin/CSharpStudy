//Определить, присутствует ли в заданном массиве, некоторое число
//git push https://ghp_bA2****************3vtX0M@github.com/AlexBulavin/CSharpStudy.git

int[] arr = new int[30];
Random r = new Random();
bool trigger = false;

//Заполняем массив рандомными числами от -1000 до +1000
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = r.Next(-1000, 1000);
    
    Console.Write($"{arr[i]} \t");
}
Console.WriteLine();

Console.Write("\nВведите  число N от -1000 до +1000 : ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < arr.Length; i++)
{
    if (number == arr[i])
    {
        Console.Write($"Число {arr[i]} присутствует в массиве\n");
        trigger = true;
        break;
    } 
}
Console.Write(!trigger ? $"Число {number} отсутствует в массиве\n" : "\n");


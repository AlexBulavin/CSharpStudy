//Написать программу замену элементов массива на противоположные
//git push https://ghp_bA2****************3vtX0M@github.com/AlexBulavin/CSharpStudy.git

int[] arr = new int[20];
Random r = new Random();

//Заполняем массив рандомными числами от -20 до +20
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = r.Next(-20, 20);
    
    Console.Write($"{arr[i]} \t");
}
Console.WriteLine();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = -arr[i];
    
    Console.Write($"{arr[i]} \t");
}

Console.WriteLine();
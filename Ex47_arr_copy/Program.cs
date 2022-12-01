//Написать программу копирования массива
Console.Write("Создаём массив\n");

int[] arr = new int[123];
int[] arrCopy = new int[arr.Length];
Random r = new Random();

//Заполняем массив рандомными числами от 0 до 99
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = r.Next(0, 99);
    Console.Write($"{arr[i]} \t");
}
Console.WriteLine("\n--------------------------------------------------------------- Выводим копию ------------------------------------------------------");

for (int i = 0; i < arr.Length; i++)
{
    arrCopy[i] = arr[i];
    Console.Write($"{arrCopy[i]} \t");
}

Console.Write("\n");

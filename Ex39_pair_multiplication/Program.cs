//Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//git push https://ghp_bA2****************3vtX0M@github.com/AlexBulavin/CSharpStudy.git

int[] arr = new int[123];
int[] arrMult = new int[arr.Length/2];
Random r = new Random();

//Заполняем массив рандомными числами от 0 до 99
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = r.Next(0, 99);
    Console.Write($"{arr[i]} \t");
}
Console.WriteLine("\n---------------------------------------------------------------");

for (int i = 0; i < arr.Length/2; i++)
{
    arrMult[i] = arr[i] * arr[arr.Length - i-1];
    Console.Write($"{arrMult[i]} \t");
}

Console.Write("\n");

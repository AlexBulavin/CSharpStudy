//Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 
//git push https://ghp_bA2****************3vtX0M@github.com/AlexBulavin/CSharpStudy.git

int[] arr = new int[8]{0, 1, 1, 0, 1, 1, 1, 0};

foreach(int i in arr)
{
    Console.Write($"{i} \t");
}

Console.WriteLine();

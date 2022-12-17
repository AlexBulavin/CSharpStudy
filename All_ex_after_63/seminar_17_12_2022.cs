using static MyLibrary;
using static System.Console;

public class seminar_17_12_2022
{
    public static void Task1()
    {
//Составить частотный словарь элементов двумерного массива
bool DEBUG = true;//false;//
string k = Select("Вводим текст вручную?  Y/N: ");

if (String.Equals(k, "Y") || String.Equals(k, "D") || String.Equals(k, "Д") || String.Equals(k, "1") || String.Equals(k, "Н"))
    {
        int m = Input("Введите размер массива m");
        int[] arr = CreateArrayInt(m);
        for (int i = 0; i<m; i++)
        {
            arr[i] = Input($"arr[i] = {arr[i]}\n");
            MaiCode(arr, DEBUG);
        }  
    }
    else
    {
        //int m = Input("Введите размер массива m");
        int[] arr = CreateArrayInt(m);
        //Заполняем массив случайными числами.
        FillRandInt(arr, 100, true, 1000, false);
        MaiCode(arr, DEBUG);

    }


}

public static void MaiCode(int[] arr, bool DEBUG)
    {

    int[] frequancyArr = CreateArrayInt(arr.Length);

    //Заполнение частотного массива нолями
    PrefillArray(frequancyArr, 1, DEBUG);

    //Вывод исходного массива в консоль
    WriteLine(PrintGood(arrName, 4));


    //Сортировка массива
    for (int i = 0; i < arr.Length - 1; i++)
        for (int j = i + 1; j < arr.Length; j++)
            if (arr[i] > arr[j]) arr[i] = arr[i] + arr[j] - (arr[j] = arr[i]);

    //Поиск частот
    for (int i = 0; i < arr.Length - 1; i++)
        for (int j = i + 1; j < arr.Length; j++)
            if (arr[i] == arr[j]) 
            {
                frequancyArr[i]++;
                arr[i] = 0;
            }


    ///Вывод на печать
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] != 0) 
        {
            Write($"{arr[i]} встречается {frequancyArr[i]}");
            WriteLine(frequancyArr[i]%10 == 1 | frequancyArr[i]%10  == 5 | frequancyArr[i]%10  == 6 | frequancyArr[i]%10  == 7 | frequancyArr[i]%10  == 8%10  | frequancyArr[i]%10  == 9 | frequancyArr[i]%10  == 0 ? " раз" : " раза");

        }
}
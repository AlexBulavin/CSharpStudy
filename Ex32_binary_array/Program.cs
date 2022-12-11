/*Задача 29: Напишите программу, которая задаёт массив из N элементов (из диапазона [0-14] ) и выводит на экран десятичное представление числа, записанного в СС по основанию 15
countingSys: 3 [9, 4, 12] => 2097
Для проверки можно использовать https://numsys.ru/convert/2097/10/15
*/
//git push https://ghp_bA2****************3vtX0M@github.com/AlexBulavin/CSharpStudy.git
using static MyLibrary123;
using static System.Console;

Write($"Введите размерность массива: ");
string dimBase = Console.ReadLine();
int arrayDimension = Convert.ToInt32(dimBase);
int dimDigit, singlePowerDigit;
char[] arrDim = new char[dimBase.Length];
WriteLine();
Write($"Введите основание системы счисления: ");
string osBase = Console.ReadLine();
char[] os = new char[osBase.Length];
for (int i = 0; i < os.Length; i++)
{
    os[i] = CharSelector((int)Char.GetNumericValue(osBase[i]), 0);//Конвертировали основние системы счисления в int и вызвали метод из библиотеки для преобразования через Unicode в подстрочный индекс
}
//WriteLine(String.Join("***", os));
int countingSys = Convert.ToInt32(osBase);
//WriteLine($"arrayDimension = {arrayDimension}\nN = {countingSys}");
int[] arr = new int[arrayDimension];
ulong res = 0, temp = 0;

for (int i = 0; i < arrayDimension; i++)
{
    //Очистить массив
    Array.Clear(arrDim, 0, arrDim.Length);
    singlePowerDigit = (int)Math.Log(arrayDimension - i, 10) + 1;//Количество цифр в показателе степени
    //WriteLine($"singlePowerDigit = {singlePowerDigit}");
    for (int j = 0; j < singlePowerDigit; j++)
    {
        dimDigit = (arrayDimension-i-1)%(int)Math.Pow(10, singlePowerDigit - j)/(int)Math.Pow(10, singlePowerDigit - j - 1);//Извлекаем значение цифры из показателя степени текущего слагаемого (элемента массива)
        arrDim[j] = CharSelector(dimDigit, 1);//Вызвали метод из библиотеки для преобразования через Unicode в подстрочный индекс
    }
    //Заполняем массив рандомными значениями
    arr[i] = Random.Shared.Next(0, countingSys);
    temp = (ulong)(arr[i] * Math.Pow(countingSys, arrayDimension - i - 1));//temp = (long)(arr[i] * Math.Pow(countingSys, arrayDimension - i - 1));
    Write($"{arr[i]}*{countingSys}{String.Join("", arrDim)}");//Выводим в консоль разложение числа по выбранному основанию
    Write(i < arrayDimension - 1 ? " + " : "\n");
    res += temp;
}

WriteLine($"{Convert.ToInt64(String.Join("", arr))}{String.Join("", os)} = {res}\u2081\u2080\n");//Выводим в консоль результат в виде 1012333₁₅ = 547473₁₀ Код \u2081\u2080 соответствует символам ₁₀
WriteLine();


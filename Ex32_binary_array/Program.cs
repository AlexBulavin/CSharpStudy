/*Задача 29: Напишите программу, которая задаёт массив из N элементов (из диапазона [0-14] ) и выводит на экран десятичное представление числа, записанного в СС по основанию 15
osBase: 3 [9, 4, 12] => 2097
Для проверки можно использовать https://numsys.ru/convert/2097/10/15
*/
//git push https://ghp_bA2****************3vtX0M@github.com/AlexBulavin/CSharpStudy.git
using static MyLibrary123;
using static System.Console;

int arrayDimension = Input($"\nВведите размерность массива от 1 до 19 включительно: ");
int dimDigit, singlePowerDigit;
char[] arrDim = new char[DigitsInNumber(arrayDimension)];
int osBase = Input($"\nВведите основание системы счисления: ");
char[] os = CreateArrayChar(DigitsInNumber(osBase));

FillArrWithDimension(os, osBase);//Заполнили массив os Unocode подстрочными символами типа ₁₀
int[] arr = CreateArrayInt(arrayDimension);
ulong res = 0, temp = 0;

for (int i = 0; i < arrayDimension; i++)
{
    //Очистить массив
    Array.Clear(arrDim, 0, arrDim.Length);
    singlePowerDigit = DigitsInNumber(arrayDimension - i);//Количество цифр в показателе степени
    //Формируем показатель степени
    for (int j = 0; j < singlePowerDigit; j++)
    {
        dimDigit = (arrayDimension-i-1)%(int)Math.Pow(10, singlePowerDigit - j)/(int)Math.Pow(10, singlePowerDigit - j - 1);//Извлекаем значение цифры из показателя степени текущего слагаемого (элемента массива)
        arrDim[j] = CharSelector(dimDigit, 1);//Вызвали метод из библиотеки для преобразования через Unicode в подстрочный индекс
    }
    //Заполняем массив рандомными значениями
    arr[i] = Random.Shared.Next(0, osBase);
    temp = (ulong)(arr[i] * Math.Pow(osBase, arrayDimension - i - 1));//temp = (long)(arr[i] * Math.Pow(osBase, arrayDimension - i - 1));
    Write($"{arr[i]}*{osBase}{String.Join("", arrDim)}");//Выводим в консоль разложение числа по выбранному основанию
    Write(i < arrayDimension - 1 ? " + " : "\n");
    res += temp;
}

WriteLine($"{Convert.ToInt64(String.Join("", arr))}{String.Join("", os)} = {res}\u2081\u2080\n");//Выводим в консоль результат в виде 1012333₁₅ = 547473₁₀ Код \u2081\u2080 соответствует символам ₁₀


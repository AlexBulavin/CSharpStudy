
using static MyLibrary;
using static System.Console;
public class FinalIt
{
    public static string[] FinalItMain()
    {
        //Фиксируем время начала работы программы
        DateTime startTime = DateTime.Now;
        Console.Clear();//Очищаем консоль
        bool DEBUG = false;//true;// Задаём режим работы - дебаг или прод 

        ChangeForegroundColor(4);
        //1. Запросить у пользователя натуральное число N
        //2. Проверить формулу;
        //3. Получить одно из разбиений на группы
        //4. Вывести его в консоль.

        ulong N = 0;
        //1. Запросить у пользователя натуральное число N
        while (N <= 0)
            N = InputUlong($"Введите натуральное число 0 < N: ", DEBUG);
        if (DEBUG) WriteLine($"selectDataGenerate = {N}");
        WriteLine($"Число N можно разбить на {(int)Math.Log(N, 2) + 1} групп.");
        WriteLine(PrintGoodTwo(GroupsNumbersArr(N), 1));
    }

    public static ulong[][] GroupsNumbersArr(ulong number)
    {

        /// Если переданное число ноль, то возвращается пустой список групп
        if (number == 0)
            return Array.Empty<ulong[]>();

        /// Если переданное число единица, то возвращается список групп с одной группой - единицей
        if (number == 1)
            return new ulong[][] { new ulong[] { 1 } };

        /// Создание массива для групп
        ulong[][] groups = new ulong[(int)Math.Log(number, 2) + 1][];
        groups[0] = new ulong[] { 1 };
        int indexGroup = 1; // Индекс добавляемой группы

        /// Создание массива чисел содержащего все числа от 1 до заданного
        /// Единица используется как маркер
        /// Вместо удаления элементов их значение будет приравниваться нулю
        /// После сортировки 1 будет разделять удалённые элементы и оставшиеся
        ulong[] numbers = new ulong[number];
        for (ulong i = 0; i < number; i++)
            numbers[i] = i + 1;

        /// Массив с промежуточными данными
        int[] group = new int[number];

        /// Цикл пока в массиве индекс единицы не последний
        ulong index1;
        while ((index1 = (ulong)Array.BinarySearch(numbers, 1)) != number - 1) /// Проверка индекса единицы
        {
            /// Копия элементов в массив группы
            Array.Copy(numbers, group, (long)number);

            int countGroup = 0; /// Количество элементов в группе
                                /// Перебор элементов группы. i - индекс проверяемого элемента
            for (ulong i = index1 + 1; i < number; i++)
            {
                if (group[i] != 0) /// Пропуск удалённых элементов
                {
                    /// Удаление из группы всех элементов кратных проверяемому, кроме его самого
                    for (ulong j = i + 1; j < number; j++)
                        if (group[j] % group[i] == 0)
                            group[j] = 0;

                    /// Удаление элемента из массива чисел
                    numbers[i] = 0;
                    /// Счётчик группы увеличивается
                    countGroup++;
                }

            }
            /// Сортировка массивов после удаления элементов
            Array.Sort(group);
            Array.Sort(numbers);

            /// Создание массива для добавления в группы
            /// и копирование в него значений старше 1
            ulong[] _gr = new ulong[countGroup];
            Array.Copy(group, Array.BinarySearch(group, 1) + 1, _gr, 0, countGroup); //Метод Array.BinarySearch(group, 1) ищет объект 1 в массиве group. Общий синтаксис такой: Array.BinarySearch(myArr, myObject);
                                                                                     // Array.Copy copies a range of elements in one Array to another Array and performs type casting and boxing as required. 
                                                                                     // Copies the first element from the int array to the Object array.
                                                                                     //Array.Copy( myIntArray, myIntArray.GetLowerBound(0), myObjArray, myObjArray.GetLowerBound(0), 1 );
            /// Добавление группы в массив групп
            groups[indexGroup] = _gr;
            indexGroup++;
        }
        /// Возврат списка групп
        return groups;
    }
}
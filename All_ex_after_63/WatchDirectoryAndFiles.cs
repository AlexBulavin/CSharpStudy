using static MyLibrary;
using static System.Console;

public class LSClass
{
    public static void MainLoop()
    {
        //Фиксируем время начала работы программы
        DateTime startTime = DateTime.Now;
        Clear();//Очищаем консоль
        bool DEBUG = true;//false;// Задаём режим работы - дебаг или прод 
        int count = 1;
        //SETTINGS
        string directoryPath = "/Users/alex/CSharpCourse/Seminar01/Ex01/CSharpStudy/All_ex_after_63";
        CatalogInfo(directoryPath);//Вызываем метод обхода всех каталогов

        Towers();//Вызываем игру Towers
    }
    static void CatalogInfo(string path, string indent = "")
    {
        DirectoryInfo catalog = new DirectoryInfo(path);
        DirectoryInfo[] catalogs = catalog.GetDirectories();
        for (int i = 0; i < catalogs.Length; i++)
        {
            ChangeForegroundColor(i % 10);
            WriteLine($"{indent}{catalogs[i].Name}");
            CatalogInfo(catalogs[i].FullName, indent + "  ");
        }
        FileInfo[] files = catalog.GetFiles();

        for (int i = 0; i < files.Length; i++)
        {
            ChangeForegroundColor(i % 2);//Выводим цвет чересполосицей
            WriteLine($"{indent}{files[i].Name}");
        }
        ResetColor();
    }
    static void Towers(string with = "1", string on = "3", string middle = "2", int count = 4)
    {
        if (count > 1) Towers(with, middle, on, count - 1);
        WriteLine($"{with} >> {on}");
        if (count > 1) Towers(middle, on, with, count - 1);
    }

}
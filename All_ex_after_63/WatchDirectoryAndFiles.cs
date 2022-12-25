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
        CatalogInfo(directoryPath);
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
}
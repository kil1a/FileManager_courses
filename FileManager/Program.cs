using FileManager.Core;
using FileManager.Logic;

namespace FileManager
{
    class Program
    {
        static void Main(string[] args)
        {
            FileManagerLogic fileManagerLogic = new FileManagerLogic();
            while (true)
            {
                Console.WriteLine("---------------------------------------------------Файловый Менеджер---------------------------------------------------");
                Console.WriteLine("----------------------------------------------------1.Добавить файл----------------------------------------------------");
                Console.WriteLine("--------------------------------------------------2.Получить все файлы-------------------------------------------------");
                Console.WriteLine("-----------------------------------------------------3.Удалить файл----------------------------------------------------");
                Console.WriteLine("---------------------------------------------4.Получить файл по расширению---------------------------------------------");
                Console.WriteLine("-----------------------------------------5.Закончить работу и выйти из менеджера---------------------------------------");
                int bb = Convert.ToInt32(Console.ReadLine());
                FileManagerLogic fileManager = new FileManagerLogic();
                string filePath = null;
                string destinationFolder = "E://ppap";
                List<string> files = fileManager.GetAllFiles(destinationFolder);
                switch (bb)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("Введите путь к файлу, не забудьте добавить его раcрешение: ");
                            filePath = Console.ReadLine();
                            if (File.Exists(filePath) == false) Console.WriteLine("Путь к файлу введен неверно!");
                        } while (File.Exists(filePath) == false);


                        fileManager.AddFile(filePath, destinationFolder);
                        Console.Clear();
                        Console.WriteLine("Успешно!\nДля выхода в меню нажмите любую клавишу");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Все добавленные файлы:");
                        foreach (string file in files)
                        {
                            Console.WriteLine(file);
                        }
                        Console.WriteLine("Для выхода в меню нажмите любую клавишу");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Удаление Файла:");
                        files = fileManager.GetAllFiles(destinationFolder);

                        foreach (string file in files)
                        {
                            Console.WriteLine(file);
                        }

                        Console.WriteLine("Выберите файл для удаления, не забудьте добавить его раcрешение:");
                        string selectedFile = Console.ReadLine();
                        fileManager.DeleteFile(destinationFolder, selectedFile);

                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 4:
                        Console.Clear();
                        OutputManager outputManager = new OutputManager();
                        outputManager.DisplayFiles(files);

                        Console.WriteLine("Выберите расширение файла:");
                        string selectedExtension = Console.ReadLine();

                        List<string> selectedFiles = fileManager.GetFilesByExtension(destinationFolder, selectedExtension);

                        outputManager.DisplaySelectedFile(selectedExtension, selectedFiles);
                        Console.WriteLine("Для выхода в меню нажмите любую клавишу");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Неверный выбор.");
                        break;


                }

            }



        }
    }
}


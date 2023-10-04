using FileManager.Core;
using FileManager.Logic;

namespace FileManager
{
    class Program
    {
        static void Main(string[] args)
        {
            FileManagerLogic fileManagerLogic = new FileManagerLogic();

           

            ////получить по значению после .
            //string extension = ".txt";
            //Console.WriteLine($"Files with extension {extension}:");
            //foreach (_File file in fileManagerLogic.GetFilesByExtension(extension))
            //{
            //    Console.WriteLine(file.Name);
            //}

            ////получить файл пользователя
            //string user = "абоба";
            //Console.WriteLine($"Files created by {user}:");
            //foreach (_File file in fileManagerLogic.GetFilesCreatedByUser(user))
            //{
            //    Console.WriteLine(file.Name);
            //}

            ////получить после 
            //DateTime date = new DateTime(2022, 1, 1);
            //Console.WriteLine($"Files modified after {date}:");
            //foreach (_File file in fileManagerLogic.GetFilesModifiedAfterDate(date))
            //{
            //    Console.WriteLine(file.Name);
            //}

            ////удаление
            //_File fileToDelete = fileManagerLogic.GetAllFiles()[0];
            //fileManagerLogic.DeleteFile(fileToDelete);

            //Console.ReadLine();


            while (true)
            {
                Console.WriteLine("---------------------------------------------------Файловый Менеджер---------------------------------------------------");
                Console.WriteLine("----------------------------------------------------1.Добавить файл----------------------------------------------------");
                Console.WriteLine("--------------------------------------------------2.Получить все файлы-------------------------------------------------");
                Console.WriteLine("---------------------------------------------3.Получить файл по расширению---------------------------------------------");
                Console.WriteLine("---------------------------------------------4.Посмотреть файл пользователя--------------------------------------------");
                Console.WriteLine("----------------------------------5.Получить файл созданный после определенного времени--------------------------------");
                Console.WriteLine("-----------------------------------------------------6.Удалить файл----------------------------------------------------");
                int bb = Convert.ToInt32(Console.ReadLine());
                string filePath = null;
                switch (bb)
                {
                    case 1:
                        Console.Clear();
                        do
                        {
                            Console.WriteLine("Введите путь к файлу, не забудьте добавить его разрешение: ");
                            filePath = Console.ReadLine();
                            if (File.Exists(filePath) == false) Console.WriteLine("Путь к файлу введен неверно!");
                        } while (File.Exists(filePath) == false);
                        Console.WriteLine("Кто создал файл: ");
                        string createdBy = Console.ReadLine();
                        fileManagerLogic.AddFile(filePath, createdBy);
                        Console.Clear();
                        Console.WriteLine("Успешно!\nДля выхода в меню нажмите любую клавишу");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Все Файлы:");
                        foreach (Core.FileInfo file in fileManagerLogic.GetAllFiles())
                        {
                            Console.WriteLine(file.Name);
                        }
                        Console.WriteLine("Для выхода в меню нажмите любую клавишу");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Введите разрешение файлов которые хотите вывести:");
                        string extension = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine($"Все файлы с расширением \"{extension}\":");
                        foreach (Core.FileInfo file in fileManagerLogic.GetFilesByExtension(extension))
                        {
                            Console.WriteLine(file.Name);
                        }Console.WriteLine("Введите разрешение файлов которые хотите вывести:");
                        Console.WriteLine("Для выхода в меню нажмите любую клавишу");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Введите имя пользователя чьи файлы вы хотите получить: ");
                        string user = Console.ReadLine();
                        Console.WriteLine($"Все файлы созданные {user}:");
                        foreach (Core.FileInfo file in fileManagerLogic.GetFilesCreatedByUser(user))
                        {
                            Console.WriteLine(file.Name);
                        }












                        break;
                    

                }

            }



        }
    }
}


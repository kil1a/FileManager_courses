using FileManager.Core;
using FileManager.Logic;

namespace FileManager
{
    class Program
    {
        static void Main(string[] args)
        {
            FileManagerLogic fileManagerLogic = new FileManagerLogic();
            //добавление
            string filePath = "C:\\Users\\TraffDWaterLow\\file.txt";
            string createdBy = "helloworld)";
            fileManagerLogic.AddFile(filePath, createdBy);

            //получить все
            Console.WriteLine("Все Файлы:");
            foreach (_File file in fileManagerLogic.GetAllFiles())
            {
                Console.WriteLine(file.Name);
            }

            //получить по значению после .
            string extension = ".txt";
            Console.WriteLine($"Files with extension {extension}:");
            foreach (_File file in fileManagerLogic.GetFilesByExtension(extension))
            {
                Console.WriteLine(file.Name);
            }

            //получить то-что создал
            string user = "John Doe";
            Console.WriteLine($"Files created by {user}:");
            foreach (_File file in fileManagerLogic.GetFilesCreatedByUser(user))
            {
                Console.WriteLine(file.Name);
            }

            //получить после окончания времени
            DateTime date = new DateTime(2022, 1, 1);
            Console.WriteLine($"Files modified after {date}:");
            foreach (_File file in fileManagerLogic.GetFilesModifiedAfterDate(date))
            {
                Console.WriteLine(file.Name);
            }

            //удаление
            _File fileToDelete = fileManagerLogic.GetAllFiles()[0];
            fileManagerLogic.DeleteFile(fileToDelete);

            Console.ReadLine();
        }
    }
}


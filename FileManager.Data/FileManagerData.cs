using FileManager.Core;

namespace FileManager.Data
{
    public class FileManagerData
    {
        private List<Core.FileInfo> files;
        public FileManagerData()
        {
            files = new List<Core.FileInfo>();
        }

        //Добавить файл в файл (добавляет файл в коллекцию файлов)
        public void AddFile(Core.FileInfo file)
        {
            files.Add(file);
        }

        //извлекает все файлы
        public List<Core.FileInfo> GetAllFiles()
        {
            return files;
        }

        //удаление определенного файла
        public void DeleteFile(Core.FileInfo file)
        {
            files.Remove(file);
        }

        //достает фйлы особого ывапывап
        public List<Core.FileInfo> GetFilesByExtension(string extension)
        {
            return files.FindAll(f => f.Extension == extension);
        }

        //поиск файлов созданных пользователем
        public List<Core.FileInfo> GetFilesCreatedByUser(string user)
        {
            return files.FindAll(f => f.CreatedBy == user);
        }

        //достает файлы измененные после срока
        public List<Core.FileInfo> GetFilesModifiedAfterDate(DateTime date)
        {
            return files.FindAll(f => f.LastModified > date);
        }
    }
}
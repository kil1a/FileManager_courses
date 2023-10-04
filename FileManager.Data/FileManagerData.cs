using FileManager.Core;

namespace FileManager.Data
{
    public class FileManagerData
    {
        private List<_File> files;
        public FileManagerData()
        {
            files = new List<_File>();
        }

        //Добавить файл в файл (добавляет файл в коллекцию файлов)
        public void AddFile(_File file)
        {
            files.Add(file);
        }

        //извлекает все файлы
        public List<_File> GetAllFiles()
        {
            return files;
        }

        //удаление определенного файла
        public void DeleteFile(_File file)
        {
            files.Remove(file);
        }

        //достает фйлы особого ывапывап
        public List<_File> GetFilesByExtension(string extension)
        {
            return files.FindAll(f => f.Extension == extension);
        }

        //поиск файлов созданных пользователем
        public List<_File> GetFilesCreatedByUser(string user)
        {
            return files.FindAll(f => f.CreatedBy == user);
        }

        //достает файлы измененные после срока
        public List<_File> GetFilesModifiedAfterDate(DateTime date)
        {
            return files.FindAll(f => f.LastModified > date);
        }
    }
}
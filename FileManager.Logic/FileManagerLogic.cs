using FileManager.Core;
using FileManager.Data;

namespace FileManager.Logic
{
    public class FileManagerLogic
    {
        private FileManagerData data;

        public FileManagerLogic()
        {
            data = new FileManagerData();
        }

        //создать файл из предоставленного пути к файлу
        public void AddFile(string filePath, string createdBy)
        {
            FileInfo fileInfo = new FileInfo(filePath);

            _File file = new _File()
            {
                Name = fileInfo.Name,
                Path = fileInfo.FullName,
                Size = fileInfo.Length,
                IsReadOnly = fileInfo.IsReadOnly,
                Extension = fileInfo.Extension,
                CreatedBy = createdBy,
                CreatedDate = fileInfo.CreationTime,
                LastModified = fileInfo.LastWriteTime
            };

            data.AddFile(file);
        }

        //достает все файлы из FileManagerData.
        public List<_File> GetAllFiles()
        {
            return data.GetAllFiles();
        }

        //удаляет определнный файл
        public void DeleteFile(_File file)
        {
            data.DeleteFile(file);
        }

        //достает файлы нужным ываджп
        public List<_File> GetFilesByExtension(string extension)
        {
            return data.GetFilesByExtension(extension);
        }

        //достает файлы созданные пользователем
        public List<_File> GetFilesCreatedByUser(string user)
        {
            return data.GetFilesCreatedByUser(user);
        }

        //достает файлы измененные после срока
        public List<_File> GetFilesModifiedAfterDate(DateTime date)
        {
            return data.GetFilesModifiedAfterDate(date);
        }
    }
}
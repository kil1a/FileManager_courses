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
            System.IO.FileInfo fileInfo = new System.IO.FileInfo(filePath);

            Core.FileInfo file = new Core.FileInfo()
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
        public List<Core.FileInfo> GetAllFiles()
        {
            return data.GetAllFiles();
        }

        //удаляет определнный файл
        public void DeleteFile(Core.FileInfo file)
        {
            data.DeleteFile(file);
        }

        //достает файлы нужным ываджп
        public List<Core.FileInfo> GetFilesByExtension(string extension)
        {
            return data.GetFilesByExtension(extension);
        }

        //достает файлы созданные пользователем
        public List<Core.FileInfo> GetFilesCreatedByUser(string user)
        {
            return data.GetFilesCreatedByUser(user);
        }

        //достает файлы измененные после срока
        public List<Core.FileInfo> GetFilesModifiedAfterDate(DateTime date)
        {
            return data.GetFilesModifiedAfterDate(date);
        }
    }
}
//using FileManager.Core;
//using FileManager.Data;
//using System.Collections.Generic;
//using System.IO;

//namespace FileManager.Logic
//{
//    public class FileManagerLogic : IFileManager
//    {
//        private FileManagerData data;

//        public FileManagerLogic()
//        {
//            data = new FileManagerData();
//        }

//        public void AddFile(string filePath, string createdBy)
//        {
//            FileInfo fileInfo = new FileInfo(filePath);

//            _File file = new _File()
//            {
//                Name = fileInfo.Name,
//                Path = fileInfo.FullName,
//                Size = fileInfo.Length,
//                IsReadOnly = fileInfo.IsReadOnly,
//                Extension = fileInfo.Extension,
//                CreatedBy = createdBy,
//                CreatedDate = fileInfo.CreationTime,
//                LastModified = fileInfo.LastWriteTime
//            };

//            data.AddFile(file);
//        }

//        public List<_File> GetAllFiles()
//        {
//            return data.GetAllFiles();
//        }

//        public void DeleteFile(_File file)
//        {
//            data.DeleteFile(file);
//        }

//        public List<_File> GetFilesByExtension(string extension)
//        {
//            return data.GetFilesByExtension(extension);
//        }

//        public List<_File> GetFilesCreatedByUser(string user)
//        {
//            return data.GetFilesCreatedByUser(user);
//        }

//        public List<_File> GetFilesModifiedAfterDate(DateTime date)
//        {
//            return data.GetFilesModifiedAfterDate(date);
//        }
//    }
//}

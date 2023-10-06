using FileManager.Core;
using FileManager.Data;

namespace FileManager.Logic
{
    public class FileManagerLogic
    {
       

        //создать файл из предоставленного пути к файлу
        public void AddFile(string filePath, string destinationFolder)
        {
            // Получаем имя файла из полного пути
            string fileName = Path.GetFileName(filePath);

            // Создаем новый путь для сохранения файла
            string newFilePath = Path.Combine(destinationFolder, fileName);

            // Копируем файл в новую папку
            File.Copy(filePath, newFilePath);
        }

        //достает все файлы из FileManagerData.
        public List<string> GetAllFiles(string destinationFolder)
        {
            List<string> files = new List<string>();

            // Получаем все файлы из выбранной папки
            files = Directory.GetFiles(destinationFolder).ToList();

            return files;
        }

        //удаляет определнный файл
        public void DeleteFile(string selectedFolder, string selectedFile)
        {
            string filePath = Path.Combine(selectedFolder, selectedFile);

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine("Файл успешно удален.");
            }
            else
            {
                Console.WriteLine("Файл не найден.");
            }
        }

        //достает файлы нужным ываджп
        public List<string> GetFilesByExtension(string selectedFolder, string selectedExtension)
        {
            string[] files = Directory.GetFiles(selectedFolder, "*." + selectedExtension);

            return files.ToList();
        }

    }
}
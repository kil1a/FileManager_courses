using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Logic
{
    public class OutputManager
    {
        public void DisplayFiles(List<string> files)
        {
            if (files.Count > 0)
            {
                Console.WriteLine("Файлы в выбранной папке:");
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }
            }
            else
            {
                Console.WriteLine("Файлы с указанным расширением не найдены.");
            }
        }

        public void DisplaySelectedFile(string selectedExtension, List<string> selectedFiles)
        {
            if (selectedFiles.Count > 0)
            {
                Console.WriteLine($"Файлы с расширением {selectedExtension}:");
                foreach (string file in selectedFiles)
                {
                    Console.WriteLine(file);
                }
            }
            else
            {
                Console.WriteLine($"Файлы с расширением {selectedExtension} не найдены.");
            }
        }
    }
}

namespace FileManager.Core
{
    public class _File
    {
        //имя
        public string Name { get; set; }
        //путь
        public string Path { get; set; }
        //размер
        public long Size { get; set; }
        //только для чтения
        public bool IsReadOnly { get; set; }
        //расширение
        public string Extension { get; set; }
        //создатель
        public string CreatedBy { get; set; }
        //дата создания
        public DateTime CreatedDate { get; set; }
        //последнее изменение
        public DateTime LastModified { get; set; }
    }
}
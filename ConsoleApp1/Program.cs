using System.Globalization;

string filePath = "test C.txt";

if (!File.Exists(filePath))
{
    Console.WriteLine("Файл не найден");
    return;
}
try
{
    using (StreamReader reader = new StreamReader(filePath))
    {
        Console.WriteLine("Начинаем чтение файла");
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }
    }
}
catch(Exception ex)
{
    Console.WriteLine($"Произошла ошибка в чтение файла {ex.Message}");
}
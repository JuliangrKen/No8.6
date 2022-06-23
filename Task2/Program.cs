// #2
// Напишите программу, которая чистит нужную нам папку от файлов  и папок, которые не использовались более 30 минут.

Console.Write("Введите полный путь до папки: ");
var path = Console.ReadLine();
if (path != null)
    Console.WriteLine(MyTask.GetDirSize(path));
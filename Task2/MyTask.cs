using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class MyTask
{
    public static long GetDirSize(string dirURL)
    {
        DirectoryInfo directory;

        try
        {
            directory = new DirectoryInfo(dirURL);
        }
        catch
        {
            Console.WriteLine("Некорректная URL дирректории!");
            return 0;
        }

        long size = 0;

        try // И без нижних try работает нормально, но пусть лучше будут, а то мало ли xD
        {
            foreach (var file in directory.GetFiles())
                size += file.Length;
        }
        catch { }

        try
        {
            foreach (DirectoryInfo dir in directory.GetDirectories())
                size += GetDirSize(dir.FullName);
        }
        catch { }

        return size;
    }
}
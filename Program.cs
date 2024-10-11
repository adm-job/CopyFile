using System;
using System.IO;
using System.Linq;
using System.Text;

namespace CopyFile;

class Program
{
    static void Main(string[] args)
    {
/*         //Получение названия файла для копирования
        string? nameFile = "settingstest.txt";
        string? nameFileFlg = "settingstest.flg";
        string? nameFileList = "listPC.txt";
        //List<string> connectList = new List<string>();

        string patch = Directory.GetCurrentDirectory();
        string filePatch = patch + "\\" + nameFile;
        string fileFlgPatch = patch + "\\" + nameFileFlg;
        string fileListPatch = patch + "\\" + nameFileList;

        var file1 = new FileInfo(filePatch);
        var file2 = new FileInfo(fileFlgPatch);



        Console.Clear();

        if (!File.Exists(filePatch))
        {
            Console.WriteLine($"Файл {nameFile} не найден");
        }
        else if (!File.Exists(fileFlgPatch))
        {
            Console.WriteLine($"Файл {fileFlgPatch} не найден");
        }
        else
        {
            Console.WriteLine("Название файла конфигурации: " + nameFile);
            Console.WriteLine("Файл находится: " + filePatch + "\n");
            Console.WriteLine("Название файла флага: " + nameFileFlg);
            Console.WriteLine("Файл находится: " + fileFlgPatch);
        }
        foreach (var line in File.ReadLines(fileListPatch))
        {
            Console.WriteLine($"{line}");
            
            file1.CopyTo(line,true);
           // file2.CopyTo(nameFileFlg,true);
        } */

        string path = @"d:\in\SoureFile.txt";
        string path2 = @"d:\in\NewFile.txt";
        FileInfo fi1 = new FileInfo(path);
        //FileInfo fi2 = new FileInfo(path2);

        try
        {
            // Create the source file.
           // using (FileStream fs = fi1.Create()) { }

            //Ensure that the target file does not exist.
/*             if (File.Exists(path2))
            {
                fi2.Delete();
            } */

            //Copy the file.f
            fi1.CopyTo(path2,true);
            Console.WriteLine("{0} was copied to {1}.", path, path2);
        }
        catch (IOException ioex)
        {
            Console.WriteLine(ioex.Message);
        }

    }
}

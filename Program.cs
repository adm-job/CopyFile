using System;
using System.IO;
using System.Linq;
using System.Text;

namespace CopyFile;

class Program
{
    static void Main(string[] args)
    {
        //Получение названия файла для копирования
        string? nameFile = "settings.txt";
        string? nameFileFlg = "settings.flg";

        string patch = Directory.GetCurrentDirectory();
        Path.GetDirectoryName(patch);
        string filePatch =  patch + "\\" + nameFile;
        string fileFlgPatch = patch + "\\" + nameFileFlg;

        if (!File.Exists(filePatch)){
            Console.WriteLine($"Файл {nameFile} не найден");
            //break;
        }

        Console.Clear();
        Console.WriteLine("Название файла конфигурации: " + nameFile);
        Console.WriteLine("Файл находится: " + filePatch);
        Console.WriteLine("Название файла флага: " + nameFileFlg);
        Console.WriteLine("Файл находится: " + fileFlgPatch);


        string[] paths = { @"d:\archives", "2001", "media", "images" };
        string fullPath = Path.Combine(paths);
        Console.WriteLine(fullPath);
        Console.ReadLine();

    }
}

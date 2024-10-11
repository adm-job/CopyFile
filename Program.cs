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
        string filePatch = patch + "\\" + nameFile;
        string fileFlgPatch = patch + "\\" + nameFileFlg;

        Console.Clear();

        if (!File.Exists(filePatch))
        {
            Console.WriteLine($"Файл {nameFile} не найден");
            //break;
        }
        else
        {
            Console.WriteLine("Название файла конфигурации: " + nameFile);
            Console.WriteLine("Файл находится: " + filePatch+ "\n");
            Console.WriteLine("Название файла флага: " + nameFileFlg);
            Console.WriteLine("Файл находится: " + fileFlgPatch);
        }

    }
}

﻿using System;
using System.IO;
using System.Linq;
using System.Text;

namespace CopyFile;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        //Получение названия файла для копирования
        string? nameFile = "settings.txt";
        string? nameFileFlg = "settings.flg";
        string? nameFileList = "listPC.txt";

        // Getting the file name

        Console.WriteLine("Нужны 3 файла settings.txt, settings.flg, listPC.txt(СПИСОК) должны лежать в папке");
        /*         Console.WriteLine("Введите имя файла конфигурации");
                string? nameFile = Console.ReadLine();
                Console.WriteLine("Введите имя файла флага");
                string? nameFileFlg = Console.ReadLine();
                string? nameFileList = "listPC.txt"; */
        Console.WriteLine("Начать копирование Y/N");
        string? toBegin;
        toBegin = Console.ReadLine().ToLower();

        if (toBegin == "y")
        {
            //Getting the file path
            string patch = Directory.GetCurrentDirectory();
            string filePatch = patch + "\\" + nameFile;
            string fileFlgPatch = patch + "\\" + nameFileFlg;
            string fileListPatch = patch + "\\" + nameFileList;

            var file1 = new FileInfo(filePatch);
            var file2 = new FileInfo(fileFlgPatch);

            Console.Clear();

            //Checking for file availability    
            if (!File.Exists(filePatch))
            {
                Console.WriteLine($"Файл {nameFile} не найден");
                Console.ReadLine();
            }
            else if (!File.Exists(fileFlgPatch))
            {
                Console.WriteLine($"Файл {fileFlgPatch} не найден");
                Console.ReadLine();
            }
            else
            {
                Console.Write("Название файла конфигурации: " + nameFile + " ");
                Console.WriteLine("Файл находится: " + filePatch + "\n");
                Console.Write("Название файла флага: " + nameFileFlg + " ");
                Console.WriteLine("Файл находится: " + fileFlgPatch + "\n");
                Console.Write("Название файла списка: " + nameFileList + " ");
                Console.WriteLine("Файл находится: " + fileListPatch);


                int numberLines = 1;

                foreach (var line in File.ReadLines(fileListPatch))
                {
                    Console.WriteLine($"{numberLines} адрес {line}");

                    try
                    {
                        file1.CopyTo((line + nameFile), true);
                        Console.WriteLine($"Файл {nameFile} скопирован");
                    }
                    catch (IOException ioex)
                    {
                        Console.WriteLine(ioex.Message);
                    }

                    try
                    {
                        file2.CopyTo((line + nameFile), true);
                        Console.WriteLine($"Файл {nameFileFlg} скопирован");
                    }
                    catch (IOException ioex)
                    {
                        Console.WriteLine(ioex.Message);
                    }
                    numberLines++;
                }
            }
        }
        else if (toBegin == "n")
        {
            Console.WriteLine("Отмена копирования");
        }

        else
            {
                Console.WriteLine("Неверный ввод");
            }

        }
    }

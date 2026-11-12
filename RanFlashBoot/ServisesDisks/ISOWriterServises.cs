using DiscUtils;
using DiscUtils.Iso9660;
using DiscUtils.Udf;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Enumeration;
using System.Net.Security;
using System.Text;
using IFileSystem = DiscUtils.IFileSystem;

namespace RanFlashBoot.ServisesDisks
{
    public class ISOWriterServises
    {
        public void WriteISO(string isoPath, string driveLetter)
        {
            using (FileStream isoStream = File.OpenRead(isoPath))
            {
                {
                    UdfReader cd = new UdfReader(isoStream);
                    foreach (var file in cd.GetFiles("", "*.*", SearchOption.AllDirectories))
                    {
                        string fullPath = Path.Combine($@"{driveLetter}:\", Path.GetFileName(file));

                        if (Directory.Exists(fullPath))
                        {
                            Directory.Delete(fullPath);
                        }
                        else
                        {
                            Directory.CreateDirectory(Path.Combine($@"{driveLetter}:\", Path.GetDirectoryName(file)));
                        }
                        var fileName = Path.GetFileName(file);
                        using (var sourceFile = cd.OpenFile(file, FileMode.Open))
                        using (var destFile = File.Create(Path.Combine($@"{driveLetter}:\", fileName)))
                        {
                            sourceFile.CopyTo(destFile);
                        }

                        



                        
                    }
                }

                
                    
                
            }
            /*using (FileStream isoStream = File.OpenRead(isoPath))
            {
                CDReader cd = new CDReader(isoStream, true);

                // Получаем все файлы в ISO-образе рекурсивно
                foreach (var file in cd.GetFiles(""))
                {
                    // Очищаем путь от начальных слэшей и букв дисков (например, "\Folder\file.txt" -> "Folder\file.txt")
                    string relativePath = file.TrimStart(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);

                    // Формируем полный целевой путь на диске E:\
                    string destFilePath = Path.Combine($@"{driveLetter}:\", relativePath);

                    // Получаем путь к папке, в которой должен лежать файл
                    string destDirectory = Path.GetDirectoryName(destFilePath);

                    // Создаем структуру папок, если она еще не создана
                    if (!string.IsNullOrEmpty(destDirectory))
                    {
                        Directory.CreateDirectory(destDirectory);
                    }

                    // Копируем сам файл
                    using (var sourceFile = cd.OpenFile(file, FileMode.Open))
                    using (var destFile = File.Create(destFilePath))
                    {
                        sourceFile.CopyTo(destFile);
                    }
                }
            }*/
        }
    }
}

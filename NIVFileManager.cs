using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.IO.Compression;

namespace ConsoleApp1
{
    class NIVFileManager
    {
        public static void MethodOne(string disk_, string path, string path2)
        {


            var directory = Directory.CreateDirectory(path);
            StreamWriter writer = new StreamWriter(path + @"\NIPdirinfo.txt");
            writer.WriteLine("Files:");
            writer.WriteLine("\nDirectories:");
            DirectoryInfo disk = new DirectoryInfo(disk_);
            foreach (var x in disk.GetDirectories())
            {
                writer.WriteLine(x.Name);
                NIVLog.Createlog("Добавлена запись"+ x.Name);
            }
            
            writer.Close();
            File.Copy(path+ @"\NIPdirinfo.txt", path2 + @"\NIPdirinfo.txt", true);
            NIVLog.Createlog("Скопирован файл"+ path2 + @"\NIPdirinfo.txt");

            File.Delete(path +  @"\NIPdirinfo.txt");
            NIVLog.Createlog("Удален файл "+ path + @"\NIPdirinfo.txt");

        }
        public static void MethodTwo(string path, string new_path, string extension)
        {
            string[] directory_files = Directory.GetFiles(path);
            //DirectoryInfo directory = new DirectoryInfo(newPath);
            foreach (string i in directory_files)
            {
                string e = Path.GetExtension(i);

                if (e == $".{extension}")
                {


                    FileInfo f = new FileInfo(i);

                    string f2 = f.Name; ;
                    string newPath = new_path + @"\" + f2;
                    f.CopyTo(newPath, true);
                    NIVLog.Createlog("Скопирован файл"+ newPath);
                    Console.WriteLine(f2);
                }
            }


        }
        public static void MethodThree()
        {
           
            
            

            ZipFile.CreateFromDirectory(@"D:/1/5", @"D:/1/6/5.zip");
            NIVLog.Createlog($"Папка  архивирована в файл zip");
            ZipFile.ExtractToDirectory(@"D:/1/6/5.zip", @"D:/1/1");
            
        }

    }

}
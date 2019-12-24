using System;
using System.IO.Compression;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            NIVDiskInfo.ShowFreeSpace();
            NIVDiskInfo.ShowFileSystem();
            NIVDiskInfo.ShowDiskInfo();
            NIVFileInfo.ShowFullPath(@"D:\License_ru.pdf");
            NIVFileInfo.ShowFullPath(@"D:\Win7_Ult_SP1_Russian_x64.iso");
            NIVFileInfo.ShowFileInfo(@"D:\License_ru.pdf");
            NIVFileInfo.ShowFileInfo(@"D:\Win7_Ult_SP1_Russian_x64.iso");
            NIVDirInfo.ShowDirInfo(@"D:\1");

            NIVFileManager.MethodOne(@"D:", @"D:\1\NIVInspect", @"D:\1\2");
            NIVFileManager.MethodTwo(@"D:\1\3\", @"D:\1\4\","txt");
           
            NIVFileManager.MethodThree();
        }
    }
}
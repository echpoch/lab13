using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace ConsoleApp1
{
    static class NIVLog
    {
        public static void   Createlog(string msg)
        {
            StreamWriter fl = new StreamWriter(@"D://1/log.txt", true);
            fl.WriteLine($"[{DateTime.Now}] {msg}");
            fl.Close();

        }
    }
}

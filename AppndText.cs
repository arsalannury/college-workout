using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AppendText
{
    class AppendText
    {
        static void Append(string[] args)
        {
            File.AppendAllText(@"N:/TestFolder/SubFolder/test.txt","this text was test");
            Console.WriteLine("writed");
            Console.ReadKey();
        }
    }
}
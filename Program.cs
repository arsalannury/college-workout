using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WorkByDirectoryAndFile
{
 class Program
 {
    static void Main(string[] args)
    {
        string Path = 
        "N:\\TestFolder\\SubFolder\\test.txt";
        TextWriter writer = new StreamWriter(Path);
        writer.Write("");
        writer.Close();
        Console.WriteLine("created");
        Console.ReadKey();
    }
 }
}




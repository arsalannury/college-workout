using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WorkByDirectoryAndFile
{
 class CreateDirectory
 {
    static void Folder(string[] args)
    {
        Directory.CreateDirectory("N:\\TestFolder\\SubFolder");
        Console.WriteLine("created");
        Console.ReadKey();
    }
 }
}




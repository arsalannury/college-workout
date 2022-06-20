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
           File.Create("N:\\TestFolder\\SubFolder\\text.txt");
           Console.WriteLine("created");
           Console.ReadKey();
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WriteDeleteText
{
    class WriteDeleteText
    {
        static void WriteDelete(string[] args)
        {
           string Path = 
           "N:\\TestFolder\\SubFolder\\test.txt";
           TextWriter writer = new StreamWriter(Path);
           writer.Write("");  // if "" deleted and if "something" re assign
           writer.Close();
           Console.WriteLine("");
           Console.ReadKey();
        }
    }
}
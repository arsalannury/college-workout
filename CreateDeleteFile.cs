using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace CreateDeleteFile
{
    class CreateDeleteFile
    {
        static void CreateDelete(string[] args)
        {
            File.Create("N:tsTrain\\ts.txt");
            File.Delete(@"N:/tsTrain/ts.txt");
            Console.ReadKey();
        }
    }
}
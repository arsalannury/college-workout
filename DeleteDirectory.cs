using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace DeleteDirectory
{
    class DeleteDirectory
    {
        static void Deleted(string[] args)
        {
            Directory.Delete("N:\\TestFolder");
            Console.WriteLine("deleted");
            Console.ReadKey();
        }
    }
}
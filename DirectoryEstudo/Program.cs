using System;
using System.IO;
using System.Collections.Generic;
namespace DirectoryEstudo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\myfolder";

            try
            {
                // listar todas as Subpastas a partir de uma pasta original
               IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS :");
                foreach(string s in folders)
                {
                    Console.WriteLine(s);
                }
                // listas os arquivos a partir de uma pasta
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES :");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
                // Criando uma nova pasta 
                Directory.CreateDirectory(path + "\\newfolder");

            }
            catch (IOException e)
            {
                Console.WriteLine("Deu erro");
                Console.WriteLine(e.Message);
            }
        }
    }
}

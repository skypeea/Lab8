using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Temp";
            if (Directory.Exists(path))
            {
                string[] fList= Directory.GetFiles(path,"*.*",SearchOption.AllDirectories);
            
                foreach (string f in fList)
                {
                    Console.WriteLine(f);
                }
            }
            else
            { Console.WriteLine("Папки не существует");
            }
        Console.ReadKey();
        
        }
    }
}

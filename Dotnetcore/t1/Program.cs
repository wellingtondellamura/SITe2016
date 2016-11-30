using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<string> nomes = new List<string>();
            nomes.Add("João");
            nomes.AddRange(new string[]{"Maria", "José"});
            nomes.ForEach(n=> Console.WriteLine(n));
            File.WriteAllLines("teste.txt",nomes);
        }
    }
}

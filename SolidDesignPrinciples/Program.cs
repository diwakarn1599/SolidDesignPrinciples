using System;
using System.IO;
using SolidDesignPrinciples.SingleResponsiblity;

namespace SolidDesignPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"C:\Users\diwakar.n\source\repos\SolidDesignPrinciples\SolidDesignPrinciples\SingleResponsiblity\srp.txt";
                string fileContents = File.ReadAllText(path);
                string[] arr = fileContents.Split(",");
                ListOperations lo = new ListOperations();
                foreach (string i in arr)
                {
                    lo.list.Add(i);
                }
                lo.AddEntry("Gate");
                lo.RemoveItem("apple");
                lo.SaveToFile(path);
                Console.WriteLine("Done");
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
          
        }
    }
}

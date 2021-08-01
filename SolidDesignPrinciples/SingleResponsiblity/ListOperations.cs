using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SolidDesignPrinciples.SingleResponsiblity
{
    public class ListOperations: Exception,IReportSaver, IReport
    {
         public List<string> list = new List<string>();
        public void AddEntry(string item) => list.Add(item);

        public void RemoveItem(string item) => list.Remove(item);

        public void SaveToFile(string path)
        {
            string str = string.Join(",", list.ToArray());
            
            File.WriteAllText(path, str);
        }
        
    }
}

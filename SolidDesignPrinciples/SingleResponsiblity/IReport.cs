using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDesignPrinciples.SingleResponsiblity
{
    public interface IReport
    {
        public  void AddEntry(string iten);
        public void RemoveItem(string item);
    }

    public interface IReportSaver
    {
        public void SaveToFile(string path);
    }
  }

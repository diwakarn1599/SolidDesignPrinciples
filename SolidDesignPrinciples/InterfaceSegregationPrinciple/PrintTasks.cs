using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDesignPrinciples.InterfaceSegregationPrinciple
{
    public interface IPrintContent
    {
        void PrintContent(string content);
    }
    public interface IPrintDuplexContent
    {
        void PrintDuplexContent(string content);
    }
    public interface ICopyContent
    {
        void CopyContent(string content);
    }
    public class HpLaserJet: IPrintContent, IPrintDuplexContent
    {
        public void PrintContent(string content)
        {
            Console.WriteLine($"Printed Content : {content}");
        }
        public void PrintDuplexContent(string content)
        {
            Console.WriteLine($"Printed Duplex Content : {content}");
        }
    }
    public class Cannon : IPrintContent, ICopyContent
    {
        public void PrintContent(string content)
        {
            Console.WriteLine($"Printed Content : {content}");
        }
        public void CopyContent(string content)
        {
            Console.WriteLine($"Copied Content : {content}");
        }
    }
}

using System;
using System.IO;
using SolidDesignPrinciples.OpenClosedPrinciple;
using SolidDesignPrinciples.SingleResponsiblity;
using SolidDesignPrinciples.LiskovSubstitutionPrinciple;
using SolidDesignPrinciples.InterfaceSegregationPrinciple;

namespace SolidDesignPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = "asdfafg";
                HpLaserJet hp = new HpLaserJet();
                hp.PrintContent(content+ " hp");
                hp.PrintDuplexContent(content + " hp");
                Cannon c = new Cannon();
                c.PrintContent(content+" cannon");
                c.CopyContent(content + " cannon");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
          
        }
    }
}

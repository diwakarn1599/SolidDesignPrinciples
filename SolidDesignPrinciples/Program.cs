using System;
using System.IO;
using SolidDesignPrinciples.OpenClosedPrinciple;
using SolidDesignPrinciples.SingleResponsiblity;

namespace SolidDesignPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double sal;
                JuniorDev jd = new JuniorDev();
                sal = jd.CalculateSalary();
                Console.WriteLine($" junior dev Salary = {sal}");
                SeniorDev sd = new SeniorDev();
                sal = sd.CalculateSalary();
                Console.WriteLine($" Senior dev Salary = {sal}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
          
        }
    }
}

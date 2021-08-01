using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDesignPrinciples.OpenClosedPrinciple
{
    public abstract class BaseSalaryCalculator
    {
        public abstract double CalculateSalary();
    }

    public class SeniorDev : BaseSalaryCalculator
    {
        public override double CalculateSalary()
        {
            double bp=10000, hra=2000, sb=800,totalSalary;
            totalSalary = bp + hra + sb;
            return totalSalary;
        }
    }
    public class JuniorDev : BaseSalaryCalculator
    {
        public override double CalculateSalary()
        {
            double bp = 5000, hra = 1000, sb = 300, totalSalary;
            totalSalary = bp + hra + sb;
            return totalSalary;
        }
    }
}

using System;
using System.IO;
using SolidDesignPrinciples.OpenClosedPrinciple;
using SolidDesignPrinciples.SingleResponsiblity;
using SolidDesignPrinciples.LiskovSubstitutionPrinciple;

namespace SolidDesignPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr ={ 1, 2, 3, 4, 5, 6 };
                Calculator sum = new SumCalculate(arr);
                Console.WriteLine($"Sum of array = {sum.CalculateSum()}");
                Calculator evenSum = new EvenSumCalculate(arr);
                Console.WriteLine($"The sum of even num in arr = {evenSum.CalculateSum()}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
          
        }
    }
}

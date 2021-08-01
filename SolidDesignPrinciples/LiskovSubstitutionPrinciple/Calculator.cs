using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolidDesignPrinciples.LiskovSubstitutionPrinciple
{
    public abstract class Calculator
    {
        protected int[] numArr;
        public Calculator(int[] arr)
        {
            numArr = arr;
        }
        public abstract int CalculateSum();
    }

    public class SumCalculate : Calculator
    {
        public SumCalculate(int[] arr) : base(arr)
        {

        }
        public override int CalculateSum()
        {
            return numArr.Sum();
        }
    }
    public class EvenSumCalculate : Calculator
    {
        public EvenSumCalculate(int[] arr) : base(arr)
        {

        }
        public override int CalculateSum()
        {
            return numArr.Where(x => x%2==0).Sum();
        }
    }
}

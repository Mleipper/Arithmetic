using System;
using System.Collections.Generic;
using System.Text;

 namespace Arithmetic.Calc
{
    public class Calculator
    {
        private readonly double[] _data;
        private readonly double _sum;
        private readonly double _mean;
        private readonly int _length;
        private readonly double _standardDiv;
        public Calculator(double[] data)
        {
            _data = data;
            _sum = setSum(_data);
            _length = data.Length;
            _mean = setMean(_data);
            _standardDiv = setStandardDiv(_data);
        }
        public string getStatsPrintOut()
        {
            var msg = $"The array is of length: {_length}" +
                $" Its sum is: {_sum} "+
                $" With a Mean of: {_mean} " +
                $"and a standard divivation of : {_standardDiv}";

                //({nowEst.Subtract(mostRecentFile).TotalMinutes:N0} mins ago). Row count: {rowCount:N0}";
            return msg;
        }
        // setter methods used in the constrution of the object. 
        #region
        private double setSum(double[] data)
        {
            double sum = 0;
            foreach (var num in data)
            {
                sum = sum + num;
            }
            return sum;
        }

        private double setMean(double[] data)
        {
            return _sum / _length;
        }

        private double setStandardDiv(double[] data)
        {
            double StandardDiv = 0;
            foreach (var num in data)
            {
                StandardDiv += Math.Pow(num - _mean,2);
            }
            return Math.Sqrt( StandardDiv/_length);

        }
        #endregion

        // getter methods for the object
        #region
        public double getStandardDiv()
        {
            return _standardDiv;
        }
        public double getMean()
        {
            return _mean;
        }

        public double getSum()
        {
            return _sum;

        }
        #endregion
    }
}

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
        private IDictionary<int, int> _dict = new Dictionary<int, int>() {{0,0 },{10,0 },{20,0 },{30,0 },{40,0 },
            {50,0 },{60,0 },{70,0 },{80,0 },{90,0 }, { 100,0} };


        public Calculator(double[] data)
        {
            _data = data;
            _sum = setSum(_data);
            _length = data.Length;
            _mean = setMean();
            _standardDiv = setStandardDiv(_data);
            setFrequenies(_data);
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

        private double setMean()
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

        public int roundDown(double item)
        {
            return  ((int)item / 10) * 10;
        }
        public void setFrequenies(double[] data)
        {
            foreach (var item in data)
            {
                var rounded = roundDown(item);

                _dict[rounded] += 1;

            }

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



        public string getStatsPrintOut()
        {
            var msg = $"The array is of length: {_length}" +
                $" Its sum is: {_sum} "+
                $" With a Mean of: {_mean} " +
                $"and a standard divivation of : {_standardDiv}";

                //({nowEst.Subtract(mostRecentFile).TotalMinutes:N0} mins ago). Row count: {rowCount:N0}";
            return msg;
        }

        public void printBininfo()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("    Bin |   Frequency  ");
            Console.WriteLine("------------------------");

            foreach (KeyValuePair<int, int> item in _dict)
            {
                Console.WriteLine($"{item.Key}-{item.Key+9}   |  {item.Value}");
            }
        }
        #endregion
    }
}

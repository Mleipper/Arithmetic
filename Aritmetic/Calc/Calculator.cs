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
        private IDictionary<string, int> _dict = new Dictionary<string, int>() {{"0<10",0 },{"10<20",0 },{"20<30",0 },{"30<40",0 },{"40<50",0 },
            {"50<60",0 },{"60<70",0 },{"70<80",0 },{"80<90",0 },{"90<=100",0 } };


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

        
        public void setFrequenies(double[] data)
        {
            foreach (var item in data)
            {
                //compare midpoint first as roughly halfs the amount of comparisons 
                if (item < 50)
                {
                    if (item < 10)
                    {
                        _dict["0<10"] += 1;
                    }
                    else if (item < 20)
                    {
                        _dict["10<20"] += 1;
                    }
                    else if (item < 30)
                    {
                        _dict["20<30"] += 1;
                    }
                    else if (item < 40)
                    {
                        _dict["30<40"] += 1;
                    }
                    else {
                        _dict["40<50"] += 1;
                    }
                }
                else {
                    if (item < 60)
                    {
                        _dict["50<60"] += 1;
                    }
                    else if (item < 70)
                    {
                        _dict["60<70"] += 1;
                    }
                    else if (item < 80)
                    {
                        _dict["70<80"] += 1;
                    }
                    else if (item < 90)
                    {
                        _dict["80<90"] += 1;
                    }
                    else {
                        _dict["90<=100"] += 1;
                    }

                }
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

            foreach (KeyValuePair<string, int> item in _dict)
            {
                Console.WriteLine($"{item.Key}   |  {item.Value}");
            }
        }
        #endregion
    }
}

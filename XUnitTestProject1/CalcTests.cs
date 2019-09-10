using System;
using Xunit;
using Arithmetic.Calc;

namespace XUnitTestProject1
{
    public class CalcTests
    {
        [Fact]
        public void TestSum()
        {
            double[] data = { 1, 2, 3 };
            Calculator test = new Calculator(data);
            var actualSum = test.getSum();
            var expected = 6;
            Assert.True(expected == actualSum);
        }

        [Fact]
        public void TestMean()
        {
            double[] data = { 1, 2, 3 };
            Calculator test = new Calculator(data);
            var actualMean = test.getMean();
            var expectedMean = 2;
            Assert.True(actualMean == expectedMean);
        }

        [Fact]
        public void TestStandardDiv()
        {
            double[] data = { 1, 2, 3 };
            Calculator test = new Calculator(data);
            var actualSD = test.getStandardDiv();
            var expectedSD = 0.816496580927726;
            Assert.True(actualSD == expectedSD);
        }

        [Fact]
        public void TestroundDown()
        {
            double[] data = { 1, 2, 3 };
            Calculator test = new Calculator(data);
            var actualSD = test.roundDown(0.1);
            var expectedSD = 0;
            Assert.True(actualSD == expectedSD);
        }
        [Fact]
        public void TestroundDownrange10()
        {
            double[] data = { 1, 2, 3 };
            Calculator test = new Calculator(data);
            var actualSD = test.roundDown(19.9);
            var expectedSD = 10;
            Assert.True(actualSD == expectedSD);
        }

        [Fact]
        public void TestroundDownrange100()
        {
            double[] data = { 1, 2, 3 };
            Calculator test = new Calculator(data);
            var actualSD = test.roundDown(100.00);
            var expectedSD = 100;
            Assert.True(actualSD == expectedSD);
        }
    }
}

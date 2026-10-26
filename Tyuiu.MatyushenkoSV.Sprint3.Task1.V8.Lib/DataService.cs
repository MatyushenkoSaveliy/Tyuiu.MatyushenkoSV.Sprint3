using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MatyushenkoSV.Sprint3.Task1.V8.Lib
{
    public class DataService : ISprint3Task1V8
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double multiplySeries = 1;
            int k = startValue;

            while (k <= stopValue)
            {
                double fraction = 1 / (Math.Cos(k) + Math.Pow(value, k));

                multiplySeries *= Math.Pow(fraction, k);

                k++; 
            }

            return Math.Round(multiplySeries, 3);
        }

        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            throw new NotImplementedException();
        }
    }
}
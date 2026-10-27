using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MatyushenkoSV.Sprint3.Task2.V7.Lib
{
    public class DataService : ISprint3Task2V7
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sumSeries = 0;
            int k = startValue;

            do
            {
                sumSeries += Math.Pow(1 / Math.Sin(k), 2);
                k++;
            } while (k <= stopValue);

            return Math.Round(sumSeries, 3);
        }
    }
}